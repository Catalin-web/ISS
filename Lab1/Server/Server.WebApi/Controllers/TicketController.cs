using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using System.Net.Mime;

namespace Server.WebApi.Controllers
{
    [ApiController]
    [Route("ticket")]
    [Produces(MediaTypeNames.Application.Json)]
    public class TicketController
    {
        private readonly ITicketFacade _ticketFacade;
        public TicketController(ITicketFacade ticketFacade)
        {
            _ticketFacade = ticketFacade;
        }

        /// <summary>
        /// Create ticket request.
        /// </summary>
        /// <response code="200">Create ticket request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateTicket(CreateTicketRequest request)
        {
            await _ticketFacade.CreateTicket(request);
        }

        /// <summary>
        /// Get all tickets.
        /// </summary>
        /// <response code="200">Get all tickets.</response>
        [HttpPost]
        [Route("get/user/{userId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Ticket>> GetAllTickets(string userId)
        {
            return await _ticketFacade.GetAllTickets(userId);
        }

        /// <summary>
        /// Get a ticket by id.
        /// </summary>
        /// <response code="200">Get a ticket by id.</response>
        [HttpPost]
        [Route("get/ticket/{ticketId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Ticket> GetTicketById(string ticketId)
        {
            return await _ticketFacade.GetTicketById(ticketId);
        }
    }
}
