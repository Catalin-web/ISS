using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class CardDataProvider : ICardDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Cards";

        public CardDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Card> Collection => _context.Database.GetCollection<Card>(_collectionName);

        public async Task<List<Card>> GetAllAsync(Expression<Func<Card, bool>> match)
        {
            return await Collection.AsQueryable().Where(match).ToListAsync();
        }

        public async Task<Card> GetAsync(Expression<Func<Card, bool>> match)
        {
            var card = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return card;
        }

        public async Task InsertAsync(Card card)
        {
            await Collection.InsertOneAsync(card);
        }
    }
}
