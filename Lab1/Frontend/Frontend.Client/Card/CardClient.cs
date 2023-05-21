using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public class CardClient : BaseClient, ICardClient
    {
        public CardClient(string baseUrl) : base(baseUrl)
        {
        }

        public async Task CreateCard(CreateCardRequest request)
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

        public async Task<Card> GetCard(string cardId)
        {
            try
            {
                var url = BaseUrl + "/get/card/" + cardId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<Card>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public async Task<List<Card>> GetCards(string userId)
        {
            try
            {
                var url = BaseUrl + "/get/user/" + userId;
                var response = await PostAsync(url);
                return await DeserializeResponseContentAsync<List<Card>>(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Card>();
            }
        }
    }
}
