using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class MovieDataProvider : IMovieDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Movies";

        public MovieDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Movie> Collection => _context.Database.GetCollection<Movie>(_collectionName);

        public async Task<List<Movie>> GetAllAsync(Expression<Func<Movie, bool>> match)
        {
            return await Collection.AsQueryable().Where(match).ToListAsync();
        }

        public async Task<Movie> GetAsync(Expression<Func<Movie, bool>> match)
        {
            var movie = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return movie;
        }

        public async Task InsertAsync(Movie movie)
        {
            await Collection.InsertOneAsync(movie);
        }
    }
}
