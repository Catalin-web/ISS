using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface ICardDataProvider
    {
        Task InsertAsync(Card card);
        Task<Card> GetAsync(Expression<Func<Card, bool>> match);
        Task<List<Card>> GetAllAsync(Expression<Func<Card, bool>> match);
    }
}
