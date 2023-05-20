using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class UserDataProvider : IUserDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Users";

        public UserDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<User> Collection => _context.Database.GetCollection<User>(_collectionName);

        public async Task<User> GetAsync(Expression<Func<User, bool>> match)
        {
            var user = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return user;
        }

        public async Task InsertAsync(User user)
        {
            await Collection.InsertOneAsync(user);
        }
    }
}
