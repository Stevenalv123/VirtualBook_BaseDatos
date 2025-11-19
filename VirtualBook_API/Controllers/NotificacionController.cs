using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;
using VirtualBook_API.DTO;

namespace VirtualBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] 
    public class NotificacionController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public NotificacionController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetMisNotificaciones()
        {
            try
            {
                int idUsuario = GetIdUsuarioActual();
                var lista = new List<NotificacionDTO>();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerMisNotificaciones, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new NotificacionDTO
                    {
                        IdNotificacion = (int)reader["IdNotificacion"],
                        IdUsuario = (int)reader["IdUsuario"],
                        IdLibro = reader["IdLibro"] == DBNull.Value ? null : (int)reader["IdLibro"],
                        Mensaje = reader["Mensaje"].ToString() ?? "",
                        TipoNotificacion = reader["TipoNotificacion"].ToString() ?? "",
                        FechaNotificacion = (DateTime)reader["FechaNotificacion"],
                        Leido = (bool)reader["Leido"]
                    });
                }

                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error al obtener notificaciones: " + ex.Message);
            }
        }

        [HttpGet("unread-count")]
        public async Task<IActionResult> GetUnreadCount()
        {
            try
            {
                int idUsuario = GetIdUsuarioActual();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ContarNotificacionesNoLeidas, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                await connection.OpenAsync();
                var result = await command.ExecuteScalarAsync();
                int count = result != null ? (int)result : 0;

                return Ok(count);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error al contar: " + ex.Message);
            }
        }

        [HttpPut("read/{id}")]
        public async Task<IActionResult> MarcarComoLeida(int id)
        {
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_MarcarNotificacionLeida, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdNotificacion", id);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error al actualizar: " + ex.Message);
            }
        }

        private int GetIdUsuarioActual()
        {
            var idClaim = User.Claims.FirstOrDefault(c => c.Type == "IdUsuario")?.Value;

            if (string.IsNullOrEmpty(idClaim))
            {
                idClaim = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            }

            if (string.IsNullOrEmpty(idClaim))
            {
                throw new Exception("Token inválido: No contiene IdUsuario.");
            }

            return int.Parse(idClaim);
        }
    }
}