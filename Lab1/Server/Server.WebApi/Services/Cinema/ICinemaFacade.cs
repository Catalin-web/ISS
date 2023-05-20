using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public interface ICinemaFacade
    {
        public Task<List<Cinema>> GetAllCinemas();
        public Task<Cinema> GetCinemaById(string cinemaId);
        public Task CreateCinema(CreateCinemaRequest request);
    }
}
