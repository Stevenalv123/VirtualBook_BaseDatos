using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using VirtualBook.Models.DTO;
using VirtualBook.Models.Repository.Interfaces;

namespace VirtualBook.Models.Repository
{
    public class LibroRepository : ILibroRepository
    {
        private readonly HttpClient _httpClient;

        public LibroRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<LibroDto>> GetLibrosAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("Libro");

                if (response.IsSuccessStatusCode)
                {
                    var libros = await response.Content.ReadFromJsonAsync<List<LibroDto>>();
                    return libros ?? new List<LibroDto>();
                }
                else
                {
                    return new List<LibroDto>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los libros.", ex);
            }
        }

        public async Task<bool> SubirLibroAsync(LibroUploadModel model)
        {
            using var form = new MultipartFormDataContent();

            try
            {
                form.Add(new StringContent(model.Titulo), "Titulo");
                form.Add(new StringContent(model.IdCategoria.ToString()), "IdCategoria");
                form.Add(new StringContent(model.IdFormato.ToString()), "IdFormato");
                form.Add(new StringContent(model.IdIdioma.ToString()), "IdIdioma");
                form.Add(new StringContent(model.Descripcion), "Descripcion");
                form.Add(new StringContent(model.NumeroPaginas.ToString()), "NumeroPaginas");

                foreach (var idAutor in model.IdsAutores)
                {
                    form.Add(new StringContent(idAutor.ToString()), "IdsAutores");
                }

                // Leer el PDF
                await using var pdfStream = File.OpenRead(model.RutaArchivoPDF);
                var pdfContent = new StreamContent(pdfStream);
                pdfContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
                form.Add(pdfContent, "ArchivoPDF", Path.GetFileName(model.RutaArchivoPDF));

                // Leer la Portada
                await using var portadaStream = File.OpenRead(model.RutaArchivoPortada);
                var portadaContent = new StreamContent(portadaStream);
                portadaContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg"); // Asumimos jpeg/png
                form.Add(portadaContent, "Portada", Path.GetFileName(model.RutaArchivoPortada));

                var response = await _httpClient.PostAsync("Libro/upload", form);

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    

        public async Task<LibroDetalleDTO?> GetLibroDetalleAsync(int idLibro)
        {
            try
            {
                // Llama al nuevo endpoint: api/Libro/{id}
                var response = await _httpClient.GetAsync($"Libro/{idLibro}");

                if (response.IsSuccessStatusCode)
                {
                    var libro = await response.Content.ReadFromJsonAsync<LibroDetalleDTO>();
                    return libro;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<byte[]> DescargarArchivoLibroAsync(int idLibro)
        {
            var response = await _httpClient.GetAsync($"Libro/download/{idLibro}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsByteArrayAsync();
            }
            else
            {
                throw new Exception("No se pudo descargar el archivo.");
            }
        }

        public async Task<List<ReporteDescargaDto>> GetReporteDescargasAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<ReporteDescargaDto>>("Libro/reporte-descargas")
                       ?? new List<ReporteDescargaDto>();
            }
            catch
            {
                return new List<ReporteDescargaDto>();
            }
        }

        public async Task<bool> AgregarFavoritoAsync(int idLibro)
        {
            var response = await _httpClient.PostAsync($"Libro/favorito?idLibro={idLibro}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> EliminarFavoritoAsync(int idLibro)
        {
            var response = await _httpClient.DeleteAsync($"Libro/favorito?idLibro={idLibro}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> VerificarFavoritoAsync(int idLibro)
        {
            try
            {
                var response = await _httpClient.GetAsync($"Libro/favorito/check?idLibro={idLibro}");
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return bool.Parse(result);
                }
                return false;
            }
            catch { return false; }
        }
        public async Task<List<LibroDto>> GetFavoritosAsync()
        {  
             //llamamos al endponin
            return await _httpClient.GetFromJsonAsync<List<LibroDto>>("Libro/favoritos") ?? new List<LibroDto>();
        }

        public async Task<bool> PublicarReseñaAsync(int idLibro, string comentario)
        {
            var request = new ReseñaUploadRequest
            {
                IdLibro = idLibro,
                Comentario = comentario
            };

            // Asegúrate de usar PostAsJsonAsync (requiere System.Net.Http.Json)
            var response = await _httpClient.PostAsJsonAsync("Libro/reseña", request);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<ResenaDTO>> GetReseñasPorLibroAsync(int idLibro)
        {
            // QUITA EL TRY-CATCH TEMPORALMENTE O HAZ ESTO:
            try
            {
                var response = await _httpClient.GetAsync($"Libro/resenas/{idLibro}");

                if (!response.IsSuccessStatusCode)
                {
                    // Esto te dirá si es error 401, 404 o 500 en un MessageBox si lo llamas desde el Form
                    throw new Exception($"Error API: {response.StatusCode} - {response.ReasonPhrase}");
                }

                return await response.Content.ReadFromJsonAsync<List<ResenaDTO>>() ?? new List<ResenaDTO>();
            }
            catch (Exception ex)
            {
                // Si estás depurando, pon un punto de interrupción aquí o lanza la excepción
                // throw; 
                MessageBox.Show(ex.Message); // Agrega System.Windows.Forms para ver esto
                return new List<ResenaDTO>();
            }
        }
    }
}
