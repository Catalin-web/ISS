using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Server.Models.Entities
{
    public class Cinema
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string TotalNumberOfSeats { get; set; }
        public string Location { get; set; }
    }
}
