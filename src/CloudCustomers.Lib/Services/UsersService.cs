using CloudCustomers.Lib.Config;
using CloudCustomers.Lib.Models;
using Microsoft.Extensions.Options;
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
        private readonly UsersApiOptions _apiConfig;

        public UsersService(HttpClient httpClient, IOptions<UsersApiOptions> apiConfig)
        {

            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _apiConfig = apiConfig?.Value ?? throw new ArgumentNullException(nameof(apiConfig));
        }

        public async Task<List<User>> GetAllUsers()
        {
            var response = await _httpClient.GetAsync(_apiConfig.Endpoint);
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
