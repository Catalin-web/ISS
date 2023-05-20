using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Get;

namespace Server.WebApi
{
    public class UserFacade : IUserFacade
    {
        private readonly IUserDataProvider _users;

        public UserFacade(IUserDataProvider users)
        {
            _users = users;
        }

        public async Task<User> GetUserById(string userId)
        {
            try
            {
                return await _users.GetAsync(user => user.Id == userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task<User> Login(GetUserRequest request)
        {
            try
            {
                return await _users.GetAsync(user => user.Email == request.Email && user.Password == request.Password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task<User> Register(CreateUserRequest request)
        {
            var user = new User()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Role = UserType.Client
            };
            try
            {
                await _users.InsertAsync(user);
                return await _users.GetAsync(user => user.Email == request.Email && user.Password == request.Password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
