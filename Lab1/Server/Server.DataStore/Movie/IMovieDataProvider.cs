using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface IMovieDataProvider
    {
        Task InsertAsync(Movie movie);
        Task<Movie> GetAsync(Expression<Func<Movie, bool>> match);
        Task<List<Movie>> GetAllAsync(Expression<Func<Movie, bool>> match);
    }
}
