using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Get;
using System.Net.Mime;

namespace Server.WebApi.Controllers
{
    [ApiController]
    [Route("projection")]
    [Produces(MediaTypeNames.Application.Json)]
    public class ProjectionController
    {
        private readonly IProjectionFacade _projectionFacade;
        public ProjectionController(IProjectionFacade projectionFacade)
        {
            _projectionFacade = projectionFacade;
        }

        /// <summary>
        /// Create projection request.
        /// </summary>
        /// <response code="200">Create projection request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateProjection(CreateProjectionRequest request)
        {

            await _projectionFacade.CreateProjection(request);
        }

        /// <summary>
        /// Get all projections by cinema.
        /// </summary>
        /// <response code="200">Get all projection cinema request.</response>
        [HttpPost]
        [Route("get/cinema")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Projection>> GetAllProjectionByCinema(GetAllProjectionOfCinemaRequest request)
        {
            return await _projectionFacade.GetAllProjectionOfCinema(request);
        }

        /// <summary>
        /// Get all projections by movie.
        /// </summary>
        /// <response code="200">Get all projection movie request.</response>
        [HttpPost]
        [Route("get/movie")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Projection>> GetAllProjectionByMovie(GetAllProjectionOfMovieRequest request)
        {
            return await _projectionFacade.GetAllProjectionOfMovie(request);
        }
    }
}
