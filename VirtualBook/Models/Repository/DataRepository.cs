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
    }
}
