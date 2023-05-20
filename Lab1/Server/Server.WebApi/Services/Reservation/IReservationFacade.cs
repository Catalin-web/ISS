using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Delete;

namespace Server.WebApi
{
    public interface IReservationFacade
    {
        Task CreateReservation(CreateReservationRequest request);
        Task<List<Reservation>> GetAllReservations(string userId);
        Task<Reservation> GetReservationById(string reservationId);
        public Task DeleteReservation(DeleteReservationRequest request);
    }
}
