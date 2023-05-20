using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public class ReservationDataProvider : IReservationDataProvider
    {
        private readonly IMongoDataContext _context;
        private readonly string _collectionName = "Reservations";

        public ReservationDataProvider(IMongoDataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        protected IMongoCollection<Reservation> Collection => _context.Database.GetCollection<Reservation>(_collectionName);

        public async Task DeleteAsync(Expression<Func<Reservation, bool>> match)
        {
            await Collection.DeleteOneAsync(match);
        }

        public async Task<List<Reservation>> GetAllAsync(Expression<Func<Reservation, bool>> match)
        {
            return await Collection.AsQueryable().Where(match).ToListAsync();
        }

        public async Task<Reservation> GetAsync(Expression<Func<Reservation, bool>> match)
        {
            var reservation = await Collection.AsQueryable()
                .FirstOrDefaultAsync(match);
            return reservation;
        }

        public async Task InsertAsync(Reservation reservation)
        {
            await Collection.InsertOneAsync(reservation);
        }
    }
}
