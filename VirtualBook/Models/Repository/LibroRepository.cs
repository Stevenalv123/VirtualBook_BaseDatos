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
    }
}
