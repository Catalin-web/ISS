using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public interface ICardFacade
    {
        Task CreateCard(CreateCardRequest request);
        Task<List<Card>> GetAllCards(string userId);
        Task<Card> GetCardById(string cardId);
    }
}
