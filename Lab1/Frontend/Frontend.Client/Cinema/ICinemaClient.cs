using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend
{
    public interface ICinemaClient
    {
        Task CreateCinema(CreateCinemaRequest request);
        Task<List<Cinema>> GetAllCinemas();
        Task<Cinema> GetCinemaById(string cinemaId);
    }
}
