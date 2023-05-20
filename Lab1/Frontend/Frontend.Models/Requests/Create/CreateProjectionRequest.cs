using Frontend.Models.Entities;

namespace Frontend.Models.Requests.Create
{
    public class CreateProjectionRequest
    {
        public string UserId { get; set; }
        public string CinemaName { get; set; }
        public string MovieName { get; set; }
        public Date Date { get; set; }
    }
}
