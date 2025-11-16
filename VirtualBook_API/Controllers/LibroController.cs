using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using VirtualBook_API.Data;
using VirtualBook_API.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace VirtualBook_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly DbContext _dbContext;

        public LibroController(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Libro
        [HttpGet]
        // [Authorize] // Descomenta esto si solo usuarios logueados pueden ver libros
        public async Task<IActionResult> GetLibros()
        {
            var libros = new List<LibroDto>();
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerLibros, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    libros.Add(MapReaderToLibroDto(reader));
                }

                return Ok(libros);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        private LibroDto MapReaderToLibroDto(SqlDataReader reader)
        {
            return new LibroDto
            {
                IdLibro = (int)reader["IdLibro"],
                Descargas = (int)reader["Descargas"],
                FechaPublicacion = (DateTime)reader["FechaPublicacion"],

                // Manejo de nulos :)
                Titulo = reader["Titulo"] == DBNull.Value ? null : reader["Titulo"].ToString(),
                Portada = reader["Portada"] == DBNull.Value ? null : reader["Portada"].ToString(),
                Descripcion = reader["Descripcion"] == DBNull.Value ? null : reader["Descripcion"].ToString(),
                NumeroPaginas = reader["NumeroPaginas"] == DBNull.Value ? null : (int?)reader["NumeroPaginas"],
                NombreCategoria = reader["NombreCategoria"] == DBNull.Value ? null : reader["NombreCategoria"].ToString(),
                NombreFormato = reader["NombreFormato"] == DBNull.Value ? null : reader["NombreFormato"].ToString(),
                NombreIdioma = reader["NombreIdioma"] == DBNull.Value ? null : reader["NombreIdioma"].ToString(),
                Publicador = reader["Publicador"] == DBNull.Value ? null : reader["Publicador"].ToString(),
                Autores = reader["Autores"] == DBNull.Value ? null : reader["Autores"].ToString()
            };
        }
    }
}
