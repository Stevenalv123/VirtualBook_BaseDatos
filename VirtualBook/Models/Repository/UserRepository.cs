using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text;
using VirtualBook.Models.DTO;
using VirtualBook.Models.Repository.Interfaces;
using VirtualBook_API.DTO;

namespace VirtualBook.Models.Repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly HttpClient _httpClient;

        public UserRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginResponse> ValidateCredentialsAsync(string email, string password)
        {
            var loginRequest = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(loginRequest),
                Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("Auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);

                if (loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
                {
                    return loginResponse;
                }
                else
                {
                    throw new Exception("Invalid response from server.");
                }
            }
            else
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"{errorData}");
            }
        }
        public async Task<List<UsuarioDto>> GetUsuariosAsync()
        {
            try
            {

                var response = await _httpClient.GetAsync("Usuarios");

                if (response.IsSuccessStatusCode)
                {
                    var usuarios = await response.Content.ReadFromJsonAsync<List<UsuarioDto>>();
                    return usuarios ?? new List<UsuarioDto>();
                }
                return new List<UsuarioDto>();
            }
            catch (Exception)
            {
              
                return new List<UsuarioDto>();
            }
        }

        public async Task<LoginResponse> GetMyProfileAsync()
        {
            var response = await _httpClient.GetAsync("Auth/me");
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var profileResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);
                if (profileResponse != null)
                {
                    return profileResponse;
                }
                else
                {
                    throw new Exception("Datos de perfil invalido.");
                }
            }

            var errorData = await response.Content.ReadAsStringAsync();
            throw new Exception($"Error al obtener perfil: {errorData}");
        }

        public async Task<bool> EnviarCorreo(string correo, string titulo, string cuerpo)
        {
            var emailRequest = new CreateEmailRequest
            {
                EmailReceptor = correo,
                Tema = titulo,
                Cuerpo = cuerpo
            };
            var content = new StringContent(JsonConvert.SerializeObject(emailRequest),
                Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Email/send", content);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error del servidor: {response.StatusCode} - {errorData}");
            }
        }

        public async Task<List<RolDTO>> GetRolesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<RolDTO>>("Auth/Roles") ?? new List<RolDTO>();
        }

        public async Task<bool> VerificarCorreoExiste(string correo)
        {
            var response = await _httpClient.GetAsync($"Auth/existe?correo={correo}");
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                bool exists = JsonConvert.DeserializeObject<bool>(responseData);
                return exists;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return false;
            }
            else
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error del servidor: {response.StatusCode} - {errorData}");
            }
        }

        public async Task<bool> RegistrarUsuario(RegisterRequest _registerRequest)
        {
            using var form = new MultipartFormDataContent();
            try
            {
                form.Add(new StringContent(_registerRequest.Nombres), "Nombres");
                form.Add(new StringContent(_registerRequest.Apellidos.ToString()), "Apellidos");
                form.Add(new StringContent(_registerRequest.Correo_Electronico.ToString()), "Correo_Electronico");
                form.Add(new StringContent(_registerRequest.Contrasena.ToString()), "Contrasena");
                form.Add(new StringContent(_registerRequest.IdRol.ToString()), "IdRol");
                form.Add(new StringContent(_registerRequest.FechaNacimiento.ToString()), "FechaNacimiento");
                form.Add(new StringContent(_registerRequest.Genero.ToString()), "Genero");

                if (!string.IsNullOrEmpty(_registerRequest.FotoPerfil) && File.Exists(_registerRequest.FotoPerfil))
                {
                    var fileStream = File.OpenRead(_registerRequest.FotoPerfil);
                    var streamContent = new StreamContent(fileStream);
                    streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    form.Add(streamContent, "FotoPerfil", Path.GetFileName(_registerRequest.FotoPerfil));
                }

                var response = await _httpClient.PostAsync("Auth/register", form);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al registrar usuario: {ex.Message}");
            }
        }

        public async Task<bool> UpdateProfileAsync(UpdateUserDTO userDto)
        {
            using var form = new MultipartFormDataContent();
            try
            {
                form.Add(new StringContent(userDto.Nombres), "Nombres");
                form.Add(new StringContent(userDto.Apellidos), "Apellidos");
                form.Add(new StringContent(userDto.FechaNacimiento.ToString("o")), "FechaNacimiento");
                form.Add(new StringContent(userDto.Genero), "Genero");

                if (!string.IsNullOrEmpty(userDto.RutaNuevaFoto) && File.Exists(userDto.RutaNuevaFoto))
                {
                    var fileStream = File.OpenRead(userDto.RutaNuevaFoto);
                    var streamContent = new StreamContent(fileStream);
                    streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    form.Add(streamContent, "FotoPerfil", Path.GetFileName(userDto.RutaNuevaFoto));
                }

                var response = await _httpClient.PutAsync("Auth/update", form);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error del servidor ({response.StatusCode}): {errorMsg}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
