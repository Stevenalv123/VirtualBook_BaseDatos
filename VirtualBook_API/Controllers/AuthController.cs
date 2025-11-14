using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;
using VirtualBook_API.DTO;
using VirtualBook_API.Models;
using VirtualBook_API.Services;
using Microsoft.AspNetCore.Authorization;

namespace VirtualBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DbContext _dbContext;
        private readonly JwtServices _jwtServices;
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _env;

        public AuthController(DbContext dbContext, JwtServices jwtServices, IConfiguration config, IWebHostEnvironment env)
        {
            _dbContext = dbContext;
            _jwtServices = jwtServices;
            _config = config;
            _env = env;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] DTO.LoginRequest loginRequest)
        {
            try
            {
                var usuario = await GetUsuarioValidado(loginRequest.Email, loginRequest.Password);
                if (usuario == null)
                {
                    return Unauthorized("Credenciales invalidas");
                }

                var token = _jwtServices.GenerateToken(usuario);
                var expiration = DateTime.UtcNow.AddMinutes(Convert.ToDouble(_config["JwtConfig:TokenValidityMins"]));

                var response = new LoginResponse
                {
                    Token = token,
                    Expiration = expiration,
                    IdUsuario = usuario.IdUsuario,
                    Nombres = usuario.Nombres,
                    Apellidos = usuario.Apellidos,
                    Correo_Electronico = usuario.Correo_Electronico,
                    IdRol = usuario.IdRol,
                    NombreRol = usuario.NombreRol,
                    FotoPerfil = usuario.FotoPerfil ?? "",
                    FechaNacimiento = usuario.FechaNacimiento,
                    Genero = usuario.Genero ?? ""
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] DTO.RegisterRequest registerRequest)
        {
            string? fotoPerfilPath = null;

            try
            {
                if (registerRequest.FotoPerfil != null && registerRequest.FotoPerfil.Length > 0)
                {
                    var uploadsFolder = Path.Combine(_env.WebRootPath, "Uploads", "ProfilePictures");
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    var extension = Path.GetExtension(registerRequest.FotoPerfil.FileName);
                    var uniqueFileName = $"{Guid.NewGuid()}{extension}";
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    await using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await registerRequest.FotoPerfil.CopyToAsync(stream);
                    }

                    fotoPerfilPath = $"/Uploads/ProfilePictures/{uniqueFileName}";
                }

                await using var connection = _dbContext!.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_RegistrarUsuario, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Nombres", registerRequest.Nombres);
                command.Parameters.AddWithValue("@Apellidos", registerRequest.Apellidos);
                command.Parameters.AddWithValue("@Correo_Electronico", registerRequest.Correo_Electronico);
                command.Parameters.AddWithValue("@Contrasena", registerRequest.Contrasena);
                command.Parameters.AddWithValue("@FotoPerfil", (object)fotoPerfilPath ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdRol", registerRequest.IdRol);
                command.Parameters.AddWithValue("@FechaNacimiento", registerRequest.FechaNacimiento);
                command.Parameters.AddWithValue("@Genero", registerRequest.Genero);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok("Usuario registrado exitosamente.");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    return Conflict("El correo electrónico ya está registrado.");
                }
                return StatusCode(500, $"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        private async Task<Usuario?> GetUsuarioValidado(string correo, string password)
        {
            Usuario? usuario = null;
            await using var connection = _dbContext.GetConnection();

            var command = new SqlCommand(Procedimientos.SP_ValidarUsuario, connection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };

            command.Parameters.AddWithValue("@CorreoUsuario", correo);
            command.Parameters.AddWithValue("@Contrasena", password);

            await connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                await reader.ReadAsync();
                usuario = new Usuario
                {
                    IdUsuario = (int)reader["IdUsuario"],
                    Nombres = reader["Nombres"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Correo_Electronico = reader["Correo_Electronico"].ToString(),
                    FotoPerfil = reader["FotoPerfil"] == DBNull.Value ? null : reader["FotoPerfil"].ToString(),
                    IdRol = (int)reader["IdRol"],
                    NombreRol = reader["NombreRol"].ToString(),
                    FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                    Genero = reader["Genero"] == DBNull.Value ? null : reader["Genero"].ToString()
                };
            }

            return usuario;
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> GetMyProfile()
        {
            var userEmail = User.Identity?.Name;

            if (string.IsNullOrEmpty(userEmail))
            {
                return Unauthorized();
            }

            var usuario = await GetUsuarioDataByEmail(userEmail);

            if (usuario == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            return Ok(usuario);
        }

        private async Task<LoginResponse?> GetUsuarioDataByEmail(string correo)
        {
            LoginResponse? usuario = null;
            await using var connection = _dbContext.GetConnection();

            var command = new SqlCommand(Procedimientos.SP_ObtenerUsuarioPorCorreo, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@CorreoUsuario", correo);

            await connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                await reader.ReadAsync();
                usuario = new LoginResponse
                {
                    IdUsuario = (int)reader["IdUsuario"],
                    Nombres = reader["Nombres"].ToString(),
                    Apellidos = reader["Apellidos"].ToString(),
                    Correo_Electronico = reader["Correo_Electronico"].ToString(),
                    FotoPerfil = reader["FotoPerfil"] == DBNull.Value ? null : reader["FotoPerfil"].ToString(),
                    IdRol = (int)reader["IdRol"],
                    NombreRol = reader["NombreRol"].ToString(),
                    FechaNacimiento = (DateTime)reader["FechaNacimiento"],
                    Genero = reader["Genero"] == DBNull.Value ? null : reader["Genero"].ToString()
                };
            }
            return usuario;
        }
    }
}
