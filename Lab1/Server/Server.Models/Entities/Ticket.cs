namespace Server.Models.Entities
{
    public class Ticket
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProjectionId { get; set; }
        public TicketType Type { get; set; }
        public int SeatNumber { get; set; }
    }
}
