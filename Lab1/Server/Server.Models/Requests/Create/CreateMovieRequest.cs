namespace Server.Models.Requests.Create
{
    public class CreateMovieRequest
    {
        public string UserId { get; set; }
        public string MovieName { get; set; }
        public int Duration { get; set; }
    }
}
