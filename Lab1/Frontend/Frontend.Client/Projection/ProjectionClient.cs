using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Get;
using SerFrontendver.Models.Requests.Get;

namespace Frontend.Client
{
    public class ProjectionClient : BaseClient, IProjectionClient
    {
        public ProjectionClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateProjection(CreateProjectionRequest request)
        {
            try
            {
                var url = BaseUrl + "/create";
                await PostAsync(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Projection>> GetAllProjectionByCinema(GetAllProjectionOfCinemaRequest request)
        {
            try
            {
                var url = BaseUrl + "/get/cinema";
                var response = await PostAsync(url, request);
                return await DeserializeResponseContentAsync<List<Projection>>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Projection>();
            }
        }

        public async Task<List<Projection>> GetAllPRojectionByMovie(GetAllProjectionOfMovieRequest request)
        {
            try
            {
                var url = BaseUrl + "/get/movie";
                var response = await PostAsync(url, request);
                return await DeserializeResponseContentAsync<List<Projection>>(response);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return new List<Projection>();
            }
        }
    }
}
