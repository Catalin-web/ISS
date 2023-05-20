using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public class CinemaClient : BaseClient, ICinemaClient 
    {
        public CinemaClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateCinema(CreateCinemaRequest request)
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

        public async Task<List<Cinema>> GetAllCinemas()
        {
            try
            {
                var url = BaseUrl + "/get";
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<List<Cinema>>(response);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Cinema>();
            }
        }

        public async Task<Cinema> GetCinemaById(string cinemaId)
        {
            try
            {
                var url = BaseUrl + "/get/" + cinemaId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<Cinema>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
