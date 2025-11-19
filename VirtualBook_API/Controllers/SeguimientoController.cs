using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SeguimientoController : ControllerBase
{
    private readonly DbContext _dbContext;

    public SeguimientoController(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost("toggle")]
    public async Task<IActionResult> ToggleSeguimiento([FromQuery] int idSeguido)
    {
        try
        {
            var idClaim = User.FindFirst("IdUsuario")?.Value
                       ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(idClaim)) return Unauthorized();
            int idSeguidor = int.Parse(idClaim);

            if (idSeguidor == idSeguido) return BadRequest("No puedes seguirte a ti mismo.");

            await using var connection = _dbContext.GetConnection();
            var command = new SqlCommand(Procedimientos.SP_ToggleSeguimiento, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@IdSeguidor", idSeguidor);
            command.Parameters.AddWithValue("@IdSeguido", idSeguido);

            await connection.OpenAsync();
            var result = (int)await command.ExecuteScalarAsync();

            return Ok(result == 1);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpGet("verificar/{idSeguido}")]
    public async Task<IActionResult> VerificarSeguimiento(int idSeguido)
    {
        try
        {
            var idClaim = User.FindFirst("IdUsuario")?.Value
                       ?? User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(idClaim)) return Unauthorized();
            int idSeguidor = int.Parse(idClaim);

            await using var connection = _dbContext.GetConnection();
            var command = new SqlCommand(Procedimientos.SP_VerificarSeguimiento, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@IdSeguidor", idSeguidor);
            command.Parameters.AddWithValue("@IdSeguido", idSeguido);

            await connection.OpenAsync();
            var result = (bool)await command.ExecuteScalarAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}