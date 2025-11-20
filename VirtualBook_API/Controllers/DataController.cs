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
    public class DataController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public DataController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Autores")]
        public async Task<IActionResult> GetAutores()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerAutores, "IdAutor", "NombreAutor"));
        }

        [HttpGet("Categorias")]
        public async Task<IActionResult> GetCategorias()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerCategorias, "IdCategoria", "NombreCategoria"));
        }

        [HttpGet("Formatos")]
        public async Task<IActionResult> GetFormatos()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerFormatos, "IdFormato", "NombreFormato"));
        }

        [HttpGet("Idiomas")]
        public async Task<IActionResult> GetIdiomas()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerIdiomas, "IdIdioma", "NombreIdioma"));
        }

        [HttpPost("Autor")]
        public async Task<IActionResult> CrearAutor([FromBody] AutorRequestDTO request)
        {
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_RegistrarAutor, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@NombreAutor", request.NombreAutor);
                command.Parameters.AddWithValue("@Biografia", (object)request.Biografia ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaNacimiento", (object)request.FechaNacimiento ?? DBNull.Value);
                command.Parameters.AddWithValue("@Nacionalidad", (object)request.Nacionalidad ?? DBNull.Value);

                await connection.OpenAsync();

                var result = await command.ExecuteScalarAsync();
                int nuevoId = Convert.ToInt32(result);

                return Ok(new { message = "Autor creado", idAutor = nuevoId });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        private async Task<List<DataDto>> GetData(string spName, string idColumn, string nombreColumn)
        {
            var list = new List<DataDto>();
            await using var connection = _dbContext.GetConnection();
            var command = new SqlCommand(spName, connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            await connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                list.Add(new DataDto
                {
                    Id = (int)reader[idColumn],
                    Nombre = reader[nombreColumn].ToString() ?? ""
                });
            }
            return list;
        }
    }
}
