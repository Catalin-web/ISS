using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Models.Requests.Delete;

namespace Frontend.Client
{
    public class ReservationClient : BaseClient, IReservationClient
    {
        public ReservationClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateReservation(CreateReservationRequest request)
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

        public async Task DeleteReservation(DeleteReservationRequest request)
        {
            try
            {
                var url = BaseUrl + "/delete";
                await PostAsync(url, request);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Reservation>> GetAllReservations(string userId)
        {
            try
            {
                var url = BaseUrl + "/get/user/" + userId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<List<Reservation>>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Reservation>();
            }
        }

        public Task<Reservation> GetReservationById(string reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
