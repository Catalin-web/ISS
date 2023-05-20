using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public interface IMovieFacade
    {
        public Task<List<Movie>> GetAllMovies();
        public Task<Movie> GetMovieById(string movieId);
        public Task CreateMovie(CreateMovieRequest request);
    }
}
