using Server.Models.Entities;

namespace Server.Models.Requests.Get
{
    public class GetAllProjectionOfCinemaRequest
    {
        public string CinemaName { get; set; }
        public Date Date { get; set; }
    }
}
