using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class ProjectionDataProvider : IProjectionDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Projections";

        public ProjectionDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Projection> Collection => _context.Database.GetCollection<Projection>(_collectionName);

        public async Task<List<Projection>> GetAllAsync(Expression<Func<Projection, bool>> match)
        {
            return await Collection.AsQueryable()
                .Where(match)
                .ToListAsync();
        }

        public async Task<Projection> GetAsync(Expression<Func<Projection, bool>> match)
        {
            var projection = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return projection;
        }

        public async Task InsertAsync(Projection projection)
        {
            await Collection.InsertOneAsync(projection);
        }
    }
}
