using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface IProjectionDataProvider
    {
        Task InsertAsync(Projection projection);
        Task<Projection> GetAsync(Expression<Func<Projection, bool>> match);
        Task<List<Projection>> GetAllAsync(Expression<Func<Projection, bool>> match);
    }
}
