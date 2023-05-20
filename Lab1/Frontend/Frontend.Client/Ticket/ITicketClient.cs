using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public interface ITicketClient
    {
        public Task CreateTicket(CreateTicketRequest request);
        public Task<List<Ticket>> GetAllTickets(string userId);
        public Task<Ticket> GetTicketById(string ticketId);
    }
}
