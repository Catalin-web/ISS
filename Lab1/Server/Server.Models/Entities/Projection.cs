using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Server.Models.Entities
{
    public class Projection
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CinemaId { get; set; }
        public string MovieId { get; set; }
        public Date Date { get; set; }
    }
}
