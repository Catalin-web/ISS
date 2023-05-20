using Server.Models.Entities;
using System.Linq.Expressions;

namespace Server.DataStore
{
    public interface ITicketDataProvider
    {
        Task InsertAsync(Ticket ticket);
        Task<Ticket> GetAsync(Expression<Func<Ticket, bool>> match);
        Task<List<Ticket>> GetAllAsync(Expression<Func<Ticket,bool>> match);
        Task DeleteAsync(Expression<Func<Ticket,bool>> match);
    }
}
