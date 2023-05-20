namespace Frontend.Models.Requests.Create
{
    public class CreateCinemaRequest
    {
        public string UserId { get; set; }
        public string CinemaName { get; set; }
        public string CinemaTotalNumberOfSeats { get; set; }
        public string CinemaLocation { get; set; }
    }
}
