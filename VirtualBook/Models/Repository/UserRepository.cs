using Newtonsoft.Json;
using System.Text;
using VirtualBook.Models.DTO;
using VirtualBook.Models.Repository.Interfaces;

namespace VirtualBook.Models.Repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;

        public UserRepository(HttpClient httpClient, string endpoint)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
        }

        public async Task<LoginResponse> ValidateCredentialsAsync(string email, string password)
        {
            var loginRequest = new LoginRequest
            {
                Email = email,
                Password = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(loginRequest),
                Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_endpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseData);

                if(loginResponse != null && !string.IsNullOrEmpty(loginResponse.Token))
                {
                    return loginResponse;
                }
                else
                {
                    throw new Exception("Invalid response from server.");
                }
            }
            else
            {
                var errorData = await response.Content.ReadAsStringAsync();
                throw new Exception($"{errorData}");
            }
        }
    }
}
