using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Get;

namespace Server.WebApi
{
    public interface IProjectionFacade
    {
        Task CreateProjection(CreateProjectionRequest request);
        Task<List<Projection>> GetAllProjectionOfCinema(GetAllProjectionOfCinemaRequest request);
        Task<List<Projection>> GetAllProjectionOfMovie(GetAllProjectionOfMovieRequest request);
    }
}
