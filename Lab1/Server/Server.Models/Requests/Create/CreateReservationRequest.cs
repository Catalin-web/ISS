using Server.Models.Entities;

namespace Server.Models.Requests.Create
{
    public class CreateReservationRequest
    {
        public string UserId { get; set; }
        public string ProjectionId { get; set; }
        public List<int> Seats { get; set; }
    }
}
