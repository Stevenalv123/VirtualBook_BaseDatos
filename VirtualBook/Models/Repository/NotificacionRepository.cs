using System.Net.Http.Json;
using VirtualBook.Models.DTO;
using VirtualBook.Models.Repository.Interfaces;

namespace VirtualBook.Models.Repository
{
    public class NotificacionRepository : INotificacionRepository
    {
        private readonly HttpClient _httpClient;

        public NotificacionRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<int> ObtenerConteoNoLeidasAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("Notificacion/unread-count");

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return int.Parse(content);
                }
            }
            catch
            {
            }
            return 0;
        }

        public async Task<List<NotificacionDTO>> ObtenerMisNotificacionesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<NotificacionDTO>>("Notificacion")
                       ?? new List<NotificacionDTO>();
            }
            catch
            {
                return new List<NotificacionDTO>();
            }
        }

        public async Task MarcarComoLeidaAsync(int idNotificacion)
        {
            try
            {
                await _httpClient.PutAsync($"Notificacion/read/{idNotificacion}", null);
            }
            catch { }
        }
    }
}