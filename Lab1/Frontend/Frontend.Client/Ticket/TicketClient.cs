using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public class TicketClient : BaseClient, ITicketClient
    {
        public TicketClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateTicket(CreateTicketRequest request)
        {
            try
            {
                var url = BaseUrl + "/create";
                await PostAsync(url, request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Ticket>> GetAllTickets(string userId)
        {
            try
            {
                var url = BaseUrl + "/get/user/" + userId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<List<Ticket>>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Ticket>();
            }
        }

        public async Task<Ticket> GetTicketById(string ticketId)
        {
            try
            {
                var url = BaseUrl + "/get/ticket/" + ticketId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<Ticket>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
