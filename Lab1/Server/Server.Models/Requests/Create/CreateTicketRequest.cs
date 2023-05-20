﻿using Server.Models.Entities;
namespace Server.Models.Requests.Create
{
    public class CreateTicketRequest
    {
        public string UserId { get; set; }
        public string CardId { get; set; }
        public string MovieName { get; set; }
        public string CinemaName { get; set; }
        public Date Date { get; set; }
        public List<int> Seats { get; set; }
    }
}
