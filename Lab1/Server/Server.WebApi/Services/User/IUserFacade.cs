using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Get;

namespace Server.WebApi
{
    public interface IUserFacade
    {
        Task<User> Register(CreateUserRequest request);
        Task<User> Login(GetUserRequest request);
        Task<User> GetUserById(string userId);
    }
}
