using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;

namespace Frontend.Client
{
    public interface ICardClient
    {
        Task CreateCard(CreateCardRequest request);
        Task<List<Card>> GetCards(string userId);
        Task<Card> GetCard(string cardId);
    }
}
