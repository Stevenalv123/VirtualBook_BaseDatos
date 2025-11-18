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
    public class DataRepository : IDataRepository
    {
        private readonly HttpClient _httpClient;

        public DataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<DataDto>> GetAutoresAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DataDto>>("Data/Autores") ?? new List<DataDto>();
        }

        public async Task<List<DataDto>> GetCategoriasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DataDto>>("Data/Categorias") ?? new List<DataDto>();
        }

        public async Task<List<DataDto>> GetFormatosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DataDto>>("Data/Formatos") ?? new List<DataDto>();
        }

        public async Task<List<DataDto>> GetIdiomasAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<DataDto>>("Data/Idiomas") ?? new List<DataDto>();
        }

        public class AutorResponse { public int idAutor { get; set; } }

        public async Task<int> CrearAutorAsync(AutorRequestDTO autor)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("Data/Autor", autor);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadFromJsonAsync<AutorResponse>();
                    return result?.idAutor ?? 0;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}
