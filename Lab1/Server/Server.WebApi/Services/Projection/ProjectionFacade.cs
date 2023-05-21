using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;
using Server.Models.Requests.Get;

namespace Server.WebApi
{
    public class ProjectionFacade : IProjectionFacade
    {
        private readonly IUserDataProvider _users;
        private readonly ICinemaDataProvider _cinemas;
        private readonly IMovieDataProvider _movies;
        public readonly IProjectionDataProvider _projections;
        public readonly IReservationDataProvider _reservations;
        public readonly ITicketDataProvider _tickets;

        public ProjectionFacade(IUserDataProvider users, ICinemaDataProvider cinemas, IMovieDataProvider movies, IProjectionDataProvider projections, IReservationDataProvider reservations, ITicketDataProvider tickets)
        {
            _users = users;
            _cinemas = cinemas;
            _movies = movies;
            _projections = projections;
            _reservations = reservations;
            _tickets = tickets;
        }

        public async Task CreateProjection(CreateProjectionRequest request)
        {
            try
            {
                var user = await _users.GetAsync(user => user.Id == request.UserId);
                if (user.Role != UserType.Admin)
                {
                    throw new ArgumentNullException("Only admin users are allowed to perform create projection action!");
                }
                var cinema = await _cinemas.GetAsync(cinema => cinema.Name == request.CinemaName);
                var movie = await _movies.GetAsync(movie => movie.Name == request.MovieName);
                var projection = new Projection()
                {
                    CinemaId = cinema.Id,
                    MovieId = movie.Id,
                    Date = request.Date
                };
                await _projections.InsertAsync(projection);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Projection>> GetAllProjectionOfCinema(GetAllProjectionOfCinemaRequest request)
        {
            try
            {
                var cinema = await _cinemas.GetAsync(cinema => cinema.Name == request.CinemaName);
                return await _projections.GetAllAsync(projection => projection.CinemaId == cinema.Id);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Projection>();
            }
        }

        public async Task<List<Projection>> GetAllProjectionOfMovie(GetAllProjectionOfMovieRequest request)
        {
            try
            {
                var cinema = await _cinemas.GetAsync(cinema => cinema.Name == request.CinemaName);
                var movie = await _movies.GetAsync(movie => movie.Name == request.MovieName);
                return await _projections.GetAllAsync(projection => projection.CinemaId == cinema.Id && projection.MovieId == movie.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Projection>();
            }
        }

        public async Task<Projection> GetProjectionById(string projectionId)
        {
            try
            {
                return await _projections.GetAsync(projection => projection.Id == projectionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
