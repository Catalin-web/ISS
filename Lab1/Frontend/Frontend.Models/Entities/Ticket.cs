using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Frontend.Models.Entities
{
    public class Ticket
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProjectionId { get; set; }
        public TicketType Type { get; set; }
        public int SeatNumber { get; set; }
    }
}
