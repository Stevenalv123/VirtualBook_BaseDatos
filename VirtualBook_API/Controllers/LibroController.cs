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
        private readonly IWebHostEnvironment _env;

        public LibroController(DbContext dbContext, IWebHostEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }

        // GET: api/Libro
        [HttpGet]
        // [Authorize] // Descomentar si solo usuarios logueados pueden ver libros
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

        [HttpGet("{id}")]
        [Authorize] // Proteger el endpoint
        public async Task<IActionResult> GetLibroDetalle(int id)
        {
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerDetallesLibro, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdLibro", id);

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    var libro = MapReaderToLibroDetalleDto(reader);
                    return Ok(libro);
                }
                else
                {
                    return NotFound("Libro no encontrado.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        [HttpPost("upload")]
        [Authorize(Roles = "Administrador,Docente")]
        public async Task<IActionResult> SubirLibro([FromForm] LibroUploadRequest request)
        {
            if (request.ArchivoPDF == null || request.ArchivoPDF.Length == 0)
                return BadRequest("No se proporcionó ningún archivo PDF.");

            if (request.Portada == null || request.Portada.Length == 0)
                return BadRequest("No se proporcionó ninguna imagen de portada.");

            string? pdfPath = null;
            string? portadaPath = null;

            try
            {
                var idPublicador = await GetIdUsuarioActualAsync();
                if (idPublicador == null)
                {
                    return Unauthorized("El token de usuario no es válido o no se encontró el usuario.");
                }

                pdfPath = await GuardarArchivoAsync(request.ArchivoPDF, "BookPdfs");
                portadaPath = await GuardarArchivoAsync(request.Portada, "BookCovers");

                // Aquí se ejectura el SP para insertar el libro en la base de datos
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_InsertarLibro, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                var idsAutoresCsv = string.Join(",", request.IdsAutores);

                command.Parameters.AddWithValue("@Titulo", request.Titulo);
                command.Parameters.AddWithValue("@IdPublicador", idPublicador.Value);
                command.Parameters.AddWithValue("@IdCategoria", request.IdCategoria);
                command.Parameters.AddWithValue("@IdFormato", request.IdFormato);
                command.Parameters.AddWithValue("@IdIdioma", request.IdIdioma);
                command.Parameters.AddWithValue("@ArchivoPDF_Path", pdfPath);
                command.Parameters.AddWithValue("@Portada_Path", portadaPath);
                command.Parameters.AddWithValue("@Descripcion", (object)request.Descripcion ?? DBNull.Value);
                command.Parameters.AddWithValue("@NumeroPaginas", (object)request.NumeroPaginas ?? DBNull.Value);
                command.Parameters.AddWithValue("@IdsAutoresCSV", idsAutoresCsv);

                await connection.OpenAsync();

                // Usamos ExecuteScalarAsync porque el SP devuelve el nuevo ID
                var nuevoIdLibro = await command.ExecuteScalarAsync();

                return Ok(new { message = "Libro subido exitosamente.", idLibro = nuevoIdLibro });
            }
            catch (SqlException ex)
            {
                BorrarArchivo(pdfPath);
                BorrarArchivo(portadaPath);
                return StatusCode(500, $"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                BorrarArchivo(pdfPath);
                BorrarArchivo(portadaPath);
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
        }

        private async Task<string> GuardarArchivoAsync(IFormFile file, string subcarpeta)
        {
            var uploadsFolder = Path.Combine(_env.WebRootPath, "Uploads", subcarpeta);
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var extension = Path.GetExtension(file.FileName);
            var uniqueFileName = $"{Guid.NewGuid()}{extension}";
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            await using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return $"/Uploads/{subcarpeta}/{uniqueFileName}";
        }

        private void BorrarArchivo(string? pathRelativo)
        {
            if (string.IsNullOrEmpty(pathRelativo)) return;
            var filePath = Path.Combine(_env.WebRootPath, pathRelativo.TrimStart('/'));

            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }

        private async Task<int?> GetIdUsuarioActualAsync()
        {
            var userEmail = User.Identity?.Name;
            if (string.IsNullOrEmpty(userEmail))
            {
                return null; // No hay token o no tiene el claim "Name"
            }

            await using var connection = _dbContext.GetConnection();
            var command = new SqlCommand(Procedimientos.SP_ObtenerIdUsuarioPorCorreo, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@CorreoUsuario", userEmail);

            await connection.OpenAsync();
            var result = await command.ExecuteScalarAsync();

            if (result != null && result != DBNull.Value)
            {
                return (int)result;
            }

            return null; // El usuario del token no existe en la DB
        }
        private LibroDetalleDTO MapReaderToLibroDetalleDto(SqlDataReader reader)
        {
            return new LibroDetalleDTO
            {
                IdLibro = (int)reader["IdLibro"],
                PublicadorId = (int)reader["PublicadorId"],
                FechaPublicacion = (DateTime)reader["FechaPublicacion"],

                Titulo = reader["Titulo"] == DBNull.Value ? null : reader["Titulo"].ToString(),
                Portada = reader["Portada"] == DBNull.Value ? null : reader["Portada"].ToString(),
                ArchivoPDF = reader["ArchivoPDF"] == DBNull.Value ? null : reader["ArchivoPDF"].ToString(),
                Descripcion = reader["Descripcion"] == DBNull.Value ? null : reader["Descripcion"].ToString(),
                NumeroPaginas = reader["NumeroPaginas"] == DBNull.Value ? null : (int?)reader["NumeroPaginas"],
                NombreCategoria = reader["NombreCategoria"] == DBNull.Value ? null : reader["NombreCategoria"].ToString(),
                NombreFormato = reader["NombreFormato"] == DBNull.Value ? null : reader["NombreFormato"].ToString(),
                NombreIdioma = reader["NombreIdioma"] == DBNull.Value ? null : reader["NombreIdioma"].ToString(),
                PublicadorNombre = reader["PublicadorNombre"] == DBNull.Value ? null : reader["PublicadorNombre"].ToString(),
                PublicadorFotoPerfil = reader["PublicadorFotoPerfil"] == DBNull.Value ? null : reader["PublicadorFotoPerfil"].ToString(),
                Autores = reader["Autores"] == DBNull.Value ? null : reader["Autores"].ToString()
            };
        }

        private LibroDto MapReaderToLibroDto(SqlDataReader reader)
        {
            return new LibroDto
            {
                IdLibro = (int)reader["IdLibro"],
                Descargas = (int)reader["Descargas"],
                FechaPublicacion = (DateTime)reader["FechaPublicacion"],

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
