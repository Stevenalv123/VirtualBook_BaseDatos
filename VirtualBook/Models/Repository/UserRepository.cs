using Newtonsoft.Json;
using System.Text;
using VirtualBook.Models.DTO;
using VirtualBook.Models.Repository.Interfaces;

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
    }
}
