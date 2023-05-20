using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public class CardFacade : ICardFacade
    {
        private readonly IUserDataProvider _users;
        private readonly ICardDataProvider _cards;

        public CardFacade(IUserDataProvider users, ICardDataProvider cards)
        {
            _users = users;
            _cards = cards;
        }

        public async Task CreateCard(CreateCardRequest request)
        {
            var card = new Card()
            {
                UserId = request.UserId,
                Number = request.CardNumber,
                Series = request.CardSeries,
                Cvv = request.CardCvv
            };
            try
            {
                await _cards.InsertAsync(card);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Card>> GetAllCards(string userId)
        {
            try
            {
                return await _cards.GetAllAsync(card => card.UserId == userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Card>();
            }
        }

        public async Task<Card> GetCardById(string cardId)
        {
            try
            {
                return await _cards.GetAsync(card => card.Id == cardId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
