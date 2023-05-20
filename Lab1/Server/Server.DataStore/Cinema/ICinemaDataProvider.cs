using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface ICinemaDataProvider
    {
        Task InsertAsync(Cinema cinema);
        Task<Cinema> GetAsync(Expression<Func<Cinema, bool>> match);
        Task<List<Cinema>> GetAllAsync(Expression<Func<Cinema, bool>> match);
    }
}
