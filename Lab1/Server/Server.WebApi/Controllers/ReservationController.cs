using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Delete;
using System.Net.Mime;

namespace Server.WebApi.Controllers
{
    [ApiController]
    [Route("reservation")]
    [Produces(MediaTypeNames.Application.Json)]
    public class ReservationController
    {
        private readonly IReservationFacade _reservationFacade;
        public ReservationController(IReservationFacade reservationFacade)
        {
            _reservationFacade = reservationFacade;
        }

        /// <summary>
        /// Create reservation request.
        /// </summary>
        /// <response code="200">Create reservation request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateReservation(CreateReservationRequest request)
        {
            await _reservationFacade.CreateReservation(request);
        }

        /// <summary>
        /// Get all reservation.
        /// </summary>
        /// <response code="200">Get all projection cinema request.</response>
        [HttpPost]
        [Route("get/user/{userId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Reservation>> GetAllReservation(string userId)
        {
            return await _reservationFacade.GetAllReservations(userId);
        }

        /// <summary>
        /// Get a reservation by id.
        /// </summary>
        /// <response code="200">Get a reservation by id.</response>
        [HttpPost]
        [Route("get/reservation/{reservationId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Reservation> GetAllProjectionByMovie(string reservationId)
        {
            return await _reservationFacade.GetReservationById(reservationId);
        }

        /// <summary>
        /// Delete a reservation.
        /// </summary>
        /// <response code="200">Delete a reservation.</response>
        [HttpPost]
        [Route("delete")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task DeleteReservation(DeleteReservationRequest request)
        {
            await _reservationFacade.DeleteReservation(request);
        }
    }
}
