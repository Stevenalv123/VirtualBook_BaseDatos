using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;
using VirtualBook_API.DTO;

namespace VirtualBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public UsuariosController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var usuarios = new List<UsuarioDto>();
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerUsuarios, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    usuarios.Add(new UsuarioDto
                    {
                        IdUsuario = (int)reader["IdUsuario"],
                        Nombres = reader["Nombres"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Correo_Electronico = reader["Correo_Electronico"].ToString(),
                        NombreRol = reader["NombreRol"].ToString(),
                        FotoPerfil = reader["FotoPerfil"] == DBNull.Value ? null : reader["FotoPerfil"].ToString()
                    });
                }

                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno: " + ex.Message);
            }
        }
    }
}