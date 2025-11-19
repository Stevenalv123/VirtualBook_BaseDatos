using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http.Headers;
using VirtualBook.Models.Repository;
using VirtualBook.Models.Repository.Interfaces;

namespace VirtualBook.Controller
{
    public class ApiClient
    {
        private static ApiClient? _instance;
        public static ApiClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ApiClient();
                }
                return _instance;
            }
        }

        private readonly HttpClient _httpClient;
        public string RootUrl { get; }
        public IUserRepository LoginUsers { get; }
        public ILibroRepository Libros { get; }
        public IDataRepository Data { get; }
        public INotificacionRepository Notificaciones { get; }

        private ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseURL"]!;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiBaseUrl)
            };
            this.RootUrl = apiBaseUrl.Replace("api/", "");
            LoginUsers = new UserRepository(_httpClient);
            Libros = new LibroRepository(_httpClient);
            Data = new DataRepository(_httpClient);
            Notificaciones = new NotificacionRepository(_httpClient);
        }

        internal void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
