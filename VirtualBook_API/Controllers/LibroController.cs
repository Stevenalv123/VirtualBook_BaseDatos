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
        // ... imports y clase ...

        // POST: api/Libro/favorito
        [HttpPost("favorito")]
        [Authorize]
        public async Task<IActionResult> AgregarFavorito([FromQuery] int idLibro)
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_AgregarFavorito, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdLibro", idLibro);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok("Agregado a favoritos.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // DELETE: api/Libro/favorito
        [HttpDelete("favorito")]
        [Authorize]
        public async Task<IActionResult> EliminarFavorito([FromQuery] int idLibro)
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_EliminarFavorito, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdLibro", idLibro);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok("Eliminado de favoritos.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // En LibroController.cs

        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrador,Docente")]
        public async Task<IActionResult> EliminarLibro(int id)
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized();

                var rolUsuario = User.Claims.FirstOrDefault(c => c.Type == System.Security.Claims.ClaimTypes.Role)?.Value;

                var libro = await ObtenerInfoBasicaLibro(id);

                if (libro == null) return NotFound("El libro no existe.");

                bool esAdmin = rolUsuario == "Administrador";
                bool esDueño = libro.PublicadorId == idUsuario;

                if (!esAdmin && !esDueño)
                {
                    return StatusCode(403, "No tienes permiso para eliminar este libro. Solo puedes eliminar los libros que tú subiste.");
                }

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_EliminarLibro, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdLibro", id);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok(new { message = "Libro eliminado correctamente." });
            }
            catch (SqlException ex)
            {
                return StatusCode(500, $"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        private async Task<LibroDetalleDTO?> ObtenerInfoBasicaLibro(int idLibro)
        {
            await using var connection = _dbContext.GetConnection();
            var command = new SqlCommand(Procedimientos.SP_ObtenerDetallesLibro, connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddWithValue("@IdLibro", idLibro);
            await connection.OpenAsync();
            var reader = await command.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return MapReaderToLibroDetalleDto(reader);
            }
            return null;
        }


        [HttpGet("mis-libros")]
        [Authorize] // Requiere token
        public async Task<IActionResult> GetMisLibros()
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();

                if (idUsuario == null) return Unauthorized();

                var libros = new List<LibroDto>();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerLibrosPorUsuario, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdPublicador", idUsuario);

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
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        // GET: api/Libro/favorito/check
        [HttpGet("favorito/check")]
        [Authorize]
        public async Task<IActionResult> VerificarFavorito([FromQuery] int idLibro)
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized();

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_VerificarFavorito, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdLibro", idLibro);

                await connection.OpenAsync();
                var result = await command.ExecuteScalarAsync(); // Devuelve true/false

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
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
                Descargas = (int)reader["Descargas"],
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

        [HttpGet("download/{id}")]
        [Authorize] 
        public async Task<IActionResult> DownloadPdf(int id)
        {
            string? rutaRelativa = null;
            string? tituloArchivo = "libro";

            try
            {
                await using var connection = _dbContext.GetConnection();
                await connection.OpenAsync();

                var command = new SqlCommand(Procedimientos.SP_ObtenerDetallesLibro, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdLibro", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        rutaRelativa = reader["ArchivoPDF"] == DBNull.Value ? null : reader["ArchivoPDF"].ToString();
                        tituloArchivo = reader["Titulo"] == DBNull.Value ? "libro" : reader["Titulo"].ToString();
                    }
                    else
                    {
                        return NotFound("El libro no existe en la base de datos.");
                    }
                }

                if (string.IsNullOrEmpty(rutaRelativa))
                {
                    return NotFound("Este libro no tiene un archivo PDF asignado en la base de datos.");
                }

                var filePath = Path.Combine(_env.WebRootPath, rutaRelativa.TrimStart('/', '\\'));

                if (!System.IO.File.Exists(filePath))
                {
                    return NotFound($"Error: El archivo físico no se encuentra en la ruta: {filePath}");
                }

                var updateCmd = new SqlCommand(Procedimientos.SP_Actualizar_Descargas, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                updateCmd.Parameters.AddWithValue("@IdLibro", id);

                await updateCmd.ExecuteNonQueryAsync();

                var bytes = await System.IO.File.ReadAllBytesAsync(filePath);

                string nombreDescarga = string.Join("_", tituloArchivo.Split(Path.GetInvalidFileNameChars())) + ".pdf";

                return File(bytes, "application/pdf", nombreDescarga);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al procesar la descarga: {ex.Message}");
            }
        }
        [HttpGet("favoritos")]
        [Authorize]
        public async Task<IActionResult> GetFavoritos()
        {
            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized();

                var libros = new List<LibroDto>();
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerFavoritosPorUsuario, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

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
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }

        [HttpGet("reporte-descargas")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> GetReporteDescargas()
        {
            var reporte = new List<ReporteDescargaDto>();
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerReporteDescargas, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    reporte.Add(new ReporteDescargaDto
                    {
                        IdLibro = (int)reader["IdLibro"],
                        Titulo = reader["Titulo"].ToString(),
                        Categoria = reader["Categoria"].ToString(),
                        Autores = reader["Autores"] == DBNull.Value ? "Sin Autor" : reader["Autores"].ToString(),
                        TotalDescargas = (int)reader["TotalDescargas"],
                        FechaPublicacion = (DateTime)reader["FechaPublicacion"]
                    });
                }
                return Ok(reporte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }

        [HttpPost("reseña")]
        [Authorize]
        public async Task<IActionResult> PublicarReseña([FromBody] ReseñaUploadRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Comentario))
                return BadRequest("El comentario no puede estar vacío.");

            try
            {
                var idUsuario = await GetIdUsuarioActualAsync();
                if (idUsuario == null) return Unauthorized("Usuario no identificado.");

                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_PublicarReseña, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@IdLibro", request.IdLibro);
                command.Parameters.AddWithValue("@Comentario", request.Comentario);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();

                return Ok(new { message = "Reseña publicada correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al publicar reseña: {ex.Message}");
            }
        }

        [HttpGet("buscar")]
        [Authorize]
        public async Task<IActionResult> BuscarLibros([FromQuery] string termino)
        {
            var libros = new List<LibroDto>();
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_BuscarLibros, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@Termino", termino);

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
                return StatusCode(500, $"Error buscando libros: {ex.Message}");
            }
        }

        [HttpGet("resenas/{idLibro}")]
        [Authorize]
        public async Task<IActionResult> GetResenas(int idLibro)
        {
            var lista = new List<ResenaDTO>();
            try
            {
                await using var connection = _dbContext.GetConnection();
                var command = new SqlCommand(Procedimientos.SP_ObtenerResenasPorLibro, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@IdLibro", idLibro);

                await connection.OpenAsync();
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new ResenaDTO
                    {
                        NombreUsuario = reader["NombreUsuario"].ToString(),
                        // Manejo seguro de nulos para la foto
                        FotoPerfil = reader["FotoPerfil"] == DBNull.Value ? null : reader["FotoPerfil"].ToString(),
                        Comentario = reader["Comentario"].ToString(),
                        // IMPORTANTE: Aquí usamos "FechaReseña" con ñ porque así lo devuelve el SP
                        FechaReseña = (DateTime)reader["FechaReseña"]
                    });
                }
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error interno: {ex.Message}");
            }
        }
    }
}  
