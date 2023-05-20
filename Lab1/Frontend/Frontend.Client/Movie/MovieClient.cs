
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public class MovieClient : BaseClient, IMovieClient
    {
        public MovieClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateMovie(CreateMovieRequest request)
        {
            try
            {
                var url = BaseUrl + "/create";
                await PostAsync(url, request);
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
                var url = BaseUrl + "/get";
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<List<Movie>>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Movie>();
            }
        }

        public async Task<Movie> GetMovieById(string movieId)
        {
            try
            {
                var url = BaseUrl + "/get/" + movieId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<Movie>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
