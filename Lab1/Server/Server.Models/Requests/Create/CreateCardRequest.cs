namespace Server.Models.Requests.Create
{
    public class CreateCardRequest
    {
        public string UserId { get; set; }
        public string CardNumber { get; set; }
        public string CardSeries { get; set; }
        public string CardCvv { get; set; }
    }
}
