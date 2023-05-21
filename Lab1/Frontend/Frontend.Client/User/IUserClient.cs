using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Get;

namespace Frontend.Client
{
    public interface IUserClient
    {
        Task<User> CreateUser(CreateUserRequest request);
        Task<User> GetUser(GetUserRequest request);
        Task<User> GetUserById(string userId);
    }
}
