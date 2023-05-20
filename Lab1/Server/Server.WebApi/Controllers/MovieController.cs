using Microsoft.AspNetCore.Mvc;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using System.Net.Mime;

namespace Server.WebApi.Controllers
{
    [ApiController]
    [Route("movie")]
    [Produces(MediaTypeNames.Application.Json)]
    public class MovieController
    {
        private readonly IMovieFacade _movieFacade;
        public MovieController(IMovieFacade movieFacade)
        {
            _movieFacade = movieFacade;
        }

        /// <summary>
        /// Create movie request.
        /// </summary>
        /// <response code="200">Create movie request.</response>
        [HttpPost]
        [Route("create")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task CreateMovie(CreateMovieRequest request)
        {

            await _movieFacade.CreateMovie(request);
        }

        /// <summary>
        /// Get all movies.
        /// </summary>
        /// <response code="200">Get all movies request.</response>
        [HttpPost]
        [Route("get")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Movie>> GetAllMovies()
        {
            return await _movieFacade.GetAllMovies();
        }

        /// <summary>
        /// Get a movie by id.
        /// </summary>
        /// <response code="200">Get a movie by id.</response>
        [HttpPost]
        [Route("get/{movieId}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Movie> GetMovieById(string movieId)
        {
            return await _movieFacade.GetMovieById(movieId);
        }
    }
}
