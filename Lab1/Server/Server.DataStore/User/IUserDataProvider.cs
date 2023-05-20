using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface IUserDataProvider
    {
        Task InsertAsync(User user);
        Task<User> GetAsync(Expression<Func<User, bool>> match);
    }
}
