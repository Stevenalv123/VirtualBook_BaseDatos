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
                return new List<LibroDto>();
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
    }
}
