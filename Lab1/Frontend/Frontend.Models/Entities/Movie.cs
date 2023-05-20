using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Frontend.Models.Entities
{
    public class Movie
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public int DurationMinutes { get; set; }
    }
}
