using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface IReservationDataProvider
    {
        Task InsertAsync(Reservation ticket);
        Task<Reservation> GetAsync(Expression<Func<Reservation, bool>> match);
        Task<List<Reservation>> GetAllAsync(Expression<Func<Reservation, bool>> match);
        Task DeleteAsync(Expression<Func<Reservation, bool>> match);
    }
}
