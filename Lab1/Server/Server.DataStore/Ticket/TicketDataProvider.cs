using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class TicketDataProvider : ITicketDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Tickets";

        public TicketDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Ticket> Collection => _context.Database.GetCollection<Ticket>(_collectionName);

        public async Task DeleteAsync(Expression<Func<Ticket, bool>> match)
        {
            await Collection.DeleteOneAsync(match);
        }

        public async Task<List<Ticket>> GetAllAsync(Expression<Func<Ticket, bool>> match)
        {
            return await Collection.AsQueryable().Where(match).ToListAsync();
        }

        public async Task<Ticket> GetAsync(Expression<Func<Ticket, bool>> match)
        {
            var ticket = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return ticket;
        }

        public async Task InsertAsync(Ticket ticket)
        {
            await Collection.InsertOneAsync(ticket);
        }
    }
}
