using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public class MovieFacade : IMovieFacade
    {
        private readonly IUserDataProvider _users;
        private readonly IMovieDataProvider _movies;

        public MovieFacade(IUserDataProvider users, IMovieDataProvider movies)
        {
            _users = users;
            _movies = movies;
        }

        public async Task CreateMovie(CreateMovieRequest request)
        {
            var movie = new Movie()
            {
                Name = request.MovieName,
                DurationMinutes = request.Duration
            };
            try
            {
                var user = await _users.GetAsync(user => user.Id == request.UserId);
                if (user.Role != UserType.Admin)
                {
                    throw new ArgumentException("User need to be admin to add a movie");
                }
                await _movies.InsertAsync(movie);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            try
            {
                return await _movies.GetAllAsync(movie => true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Movie>();
            }
        }

        public async Task<Movie> GetMovieById(string movieId)
        {
            try
            {
                return await _movies.GetAsync(movie => movie.Id == movieId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
