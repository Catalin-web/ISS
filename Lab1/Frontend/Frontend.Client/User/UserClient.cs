using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Get;

namespace Frontend.Client
{
    public class UserClient : BaseClient, IUserClient
    {
        public UserClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task<User> CreateUser(CreateUserRequest request)
        {
            try
            {
                var url = BaseUrl + "/create";
                var response = await PostAsync(url, request);
                return await DeserializeResponseContentAsync<User>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task<User> GetUser(GetUserRequest request)
        {
            try
            {
                var url = BaseUrl + "/get";
                var response = await PostAsync(url, request);
                return await DeserializeResponseContentAsync<User>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task<User> GetUserById(string userId)
        {
            try
            {
                var url = BaseUrl + "/get/" + userId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<User>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
