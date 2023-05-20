namespace Server.Models.Entities
{
    public class Card
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Number { get; set; }
        public string Series { get; set; }
        public string Cvv { get; set; }
    }
}
