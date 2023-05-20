using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public interface IMovieClient
    {
        public Task CreateMovie(CreateMovieRequest request);
        public Task<List<Movie>> GetAllMovies();
        public Task<Movie> GetMovieById(string movieId);
    }
}
