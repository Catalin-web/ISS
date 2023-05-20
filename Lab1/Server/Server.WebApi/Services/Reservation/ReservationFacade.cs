using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Delete;

namespace Server.WebApi
{
    public class ReservationFacade : IReservationFacade
    {
        private readonly IUserDataProvider _users;
        private readonly ICinemaDataProvider _cinemas;
        private readonly IMovieDataProvider _movies;
        public readonly IProjectionDataProvider _projections;
        public readonly IReservationDataProvider _reservations;
        public readonly ITicketDataProvider _tickets;

        public ReservationFacade(IUserDataProvider users, ICinemaDataProvider cinemas, IMovieDataProvider movies, IProjectionDataProvider projections, IReservationDataProvider reservations, ITicketDataProvider tickets)
        {
            _users = users;
            _cinemas = cinemas;
            _movies = movies;
            _projections = projections;
            _reservations = reservations;
            _tickets = tickets;
        }

        public async Task CreateReservation(CreateReservationRequest request)
        {
            try
            {
                foreach (var seat in request.Seats)
                {
                    var ticket = new Ticket()
                    {
                        UserId = request.UserId,
                        ProjectionId = request.ProjectionId,
                        Type = TicketType.RESERVED,
                        SeatNumber = seat
                    };
                    await _tickets.InsertAsync(ticket);
                    ticket = await _tickets.GetAsync(ticket => ticket.UserId == request.UserId && ticket.ProjectionId == request.ProjectionId && ticket.Type == TicketType.RESERVED && ticket.SeatNumber == seat);
                    var reservation = new Reservation()
                    {
                        UserId = request.UserId,
                        TicketId = ticket.Id
                    };
                    await _reservations.InsertAsync(reservation);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public async Task<List<Reservation>> GetAllReservations(string userId)
        {
            try
            {
                return await _reservations.GetAllAsync(reservation => reservation.UserId == userId);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
                return new List<Reservation>();
            }
        }

        public async Task<Reservation> GetReservationById(string reservationId)
        {
            try
            {
                return await _reservations.GetAsync(reservation => reservation.Id == reservationId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task DeleteReservation(DeleteReservationRequest request)
        {
            try
            {
                var user = await _users.GetAsync(user => user.Id == request.UserId);
                if (user.Role != UserType.Admin)
                {
                    throw new ArgumentNullException("Only admin users are allowed to perform delete operation");
                }
                var reservation = await _reservations.GetAsync(reservation => reservation.Id == request.ReservationId);
                await _reservations.DeleteAsync(reservation => reservation.Id == request.ReservationId);
                await _tickets.DeleteAsync(ticket => ticket.Id == reservation.TicketId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
