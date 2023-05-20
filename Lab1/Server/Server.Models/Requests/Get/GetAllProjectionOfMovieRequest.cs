using Server.Models.Entities;
namespace Server.Models.Requests.Get
{
    public class GetAllProjectionOfMovieRequest
    {
        public string CinemaName { get; set; }
        public string MovieName { get; set; }
    }
}
