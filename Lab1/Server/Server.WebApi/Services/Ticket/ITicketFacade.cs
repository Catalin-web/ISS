using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public interface ITicketFacade
    {
        Task CreateTicket(CreateTicketRequest request);
        Task<List<Ticket>> GetAllTickets(string userId);
        Task<Ticket> GetTicketById(string ticketId);
    }
}
