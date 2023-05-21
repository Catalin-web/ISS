using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Delete;

namespace Frontend.Client
{
    public interface IReservationClient
    {
        Task CreateReservation(CreateReservationRequest request);
        Task<List<Reservation>> GetAllReservations(string userId);
        Task<Reservation> GetReservationById(string reservationId);
        Task DeleteReservation(DeleteReservationRequest request);
        Task<List<Reservation>> GetAll();
    }
}
