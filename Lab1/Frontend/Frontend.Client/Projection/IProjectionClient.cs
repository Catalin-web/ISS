using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Get;
using SerFrontendver.Models.Requests.Get;

namespace Frontend.Client
{
    public interface IProjectionClient
    {
        Task CreateProjection(CreateProjectionRequest request);
        Task<List<Projection>> GetAllProjectionByCinema(GetAllProjectionOfCinemaRequest request);
        Task<List<Projection>> GetAllPRojectionByMovie(GetAllProjectionOfMovieRequest request);
    }
}
