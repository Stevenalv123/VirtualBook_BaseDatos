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

        // GET: api/Data/Autores
        [HttpGet("Autores")]
        public async Task<IActionResult> GetAutores()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerAutores, "IdAutor", "NombreAutor"));
        }

        // GET: api/Data/Categorias
        [HttpGet("Categorias")]
        public async Task<IActionResult> GetCategorias()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerCategorias, "IdCategoria", "NombreCategoria"));
        }

        // GET: api/Data/Formatos
        [HttpGet("Formatos")]
        public async Task<IActionResult> GetFormatos()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerFormatos, "IdFormato", "NombreFormato"));
        }

        // GET: api/Data/Idiomas
        [HttpGet("Idiomas")]
        public async Task<IActionResult> GetIdiomas()
        {
            return Ok(await GetData(Procedimientos.SP_ObtenerIdiomas, "IdIdioma", "NombreIdioma"));
        }

        // Método para leer los datos
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
