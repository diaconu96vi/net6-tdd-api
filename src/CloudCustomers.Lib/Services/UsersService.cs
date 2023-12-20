using CloudCustomers.Lib.Models;
using System.Net;
using System.Net.Http.Json;

namespace CloudCustomers.Lib.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }

    public class UsersService: IUserService
    {
        private readonly HttpClient _httpClient;
        public UsersService(HttpClient httpClient)
        {

            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        }

        public async Task<List<User>> GetAllUsers()
        {
            var response = await _httpClient.GetAsync("https://example.com");
            if(response.StatusCode == HttpStatusCode.NotFound)
            {
                return new List<User>();
            }
            var responseContent = response.Content;
            var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
            return allUsers;
        }
    }
}
