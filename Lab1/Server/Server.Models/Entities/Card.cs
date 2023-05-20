using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Server.Models.Entities
{
    public class Card
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Number { get; set; }
        public string Series { get; set; }
        public string Cvv { get; set; }
    }
}
