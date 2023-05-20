using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public class TicketFacade : ITicketFacade
    {
        private readonly ICinemaDataProvider _cinemas;
        private readonly IMovieDataProvider _movies;
        public readonly IProjectionDataProvider _projections;
        public readonly IReservationDataProvider _reservations;
        public readonly ITicketDataProvider _tickets;

        public TicketFacade(ICinemaDataProvider cinemas, IMovieDataProvider movies, IProjectionDataProvider projections, IReservationDataProvider reservations, ITicketDataProvider tickets)
        {
            _cinemas = cinemas;
            _movies = movies;
            _projections = projections;
            _reservations = reservations;
            _tickets = tickets;
        }

        public async Task CreateTicket(CreateTicketRequest request)
        {
            try
            {
                foreach (var seat in request.Seats)
                {
                    var ticket = new Ticket()
                    {
                        UserId = request.UserId,
                        ProjectionId = request.ProjectionId,
                        Type = TicketType.PURCHASED,
                        SeatNumber = seat
                    };
                    await _tickets.InsertAsync(ticket);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Ticket>> GetAllTickets(string userId)
        {
            try
            {
                return await _tickets.GetAllAsync(ticket => ticket.UserId == userId);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Ticket>();
            }
        }

        public async Task<Ticket> GetTicketById(string ticketId)
        {
            try
            {
                return await _tickets.GetAsync(ticket => ticket.Id == ticketId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
