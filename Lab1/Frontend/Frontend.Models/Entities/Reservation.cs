using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Frontend.Models.Entities
{
    public class Reservation
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string TicketId { get; set; }
        public string UserId { get; set; }
    }
}
