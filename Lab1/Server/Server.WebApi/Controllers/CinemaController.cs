using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using System.Net.Mime;

namespace Server.WebApi.Controllers
{
    [ApiController]
    [Route("cinema")]
    [Produces(MediaTypeNames.Application.Json)]
    public class CinemaController
    {
        private readonly ICinemaFacade _cinemaFacade;
        public CinemaController(ICinemaFacade cinemaFacade) 
        {
            _cinemaFacade = cinemaFacade;
        }

        /// <summary>
        /// Create cinema request.
        /// </summary>
        /// <response code="200">Create cinema request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateCinema(CreateCinemaRequest request)
        {

            await _cinemaFacade.CreateCinema(request);
        }

        /// <summary>
        /// Get all cinemas.
        /// </summary>
        /// <response code="200">Get all cinema request.</response>
        [HttpPost]
        [Route("get")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Cinema>> GetAllCinemas()
        {
            return await _cinemaFacade.GetAllCinemas();
        }

        /// <summary>
        /// Get a cinema by id.
        /// </summary>
        /// <response code="200">Get a cinema by id.</response>
        [HttpPost]
        [Route("get/{cinemaId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Cinema> GetCinemaById(string cinemaId)
        {
            return await _cinemaFacade.GetCinemaById(cinemaId);
        }
    }
}
