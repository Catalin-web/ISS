using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class CinemaDataProvider : ICinemaDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Cinemas";

        public CinemaDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Cinema> Collection => _context.Database.GetCollection<Cinema>(_collectionName);

        public async Task<List<Cinema>> GetAllAsync(Expression<Func<Cinema, bool>> match)
        {
            return await Collection.AsQueryable().Where(match).ToListAsync();
        }

        public async Task<Cinema> GetAsync(Expression<Func<Cinema, bool>> match)
        {
            var cinema = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return cinema;
        }

        public async Task InsertAsync(Cinema cinema)
        {
            await Collection.InsertOneAsync(cinema);
        }
    }
}
