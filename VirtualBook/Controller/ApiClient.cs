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
        private readonly HttpClient _httpClient;
        public IUserRepository LoginUsers { get; }
        public ILibroRepository Libros { get; }

        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseURL"]!;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiBaseUrl)
            };
            LoginUsers = new UserRepository(_httpClient);
            Libros = new LibroRepository(_httpClient);
        }

        internal void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
    }
}
