using MongoDB.Driver;

namespace Server.DataStore
{
    public interface IMongoDataContext
    {
        IMongoDatabase Database { get; }
    }
}
