using Server.DataStore;
using Server.Models.Entities;
using Server.Models.Requests.Create;

namespace Server.WebApi
{
    public class CinemaFacade : ICinemaFacade
    {
        private readonly IUserDataProvider _users;
        private readonly ICinemaDataProvider _cinemas;

        public CinemaFacade(IUserDataProvider users, ICinemaDataProvider cinemas)
        {
            _users = users;
            _cinemas = cinemas;
        }

        public async Task CreateCinema(CreateCinemaRequest request)
        {
            var cinema = new Cinema()
            {
                Name = request.CinemaName,
                TotalNumberOfSeats = request.CinemaTotalNumberOfSeats,
                Location = request.CinemaLocation
            };
            try
            {
                var user = await _users.GetAsync(user => user.Id == request.UserId);
                if (user.Role != UserType.Admin)
                {
                    throw new ArgumentException("User need to be admin to add a cinema");
                }
                await _cinemas.InsertAsync(cinema);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async Task<List<Cinema>> GetAllCinemas()
        {
            try
            {
                return await _cinemas.GetAllAsync(cinema => true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Cinema>();
            }
        }

        public async Task<Cinema> GetCinemaById(string cinemaId)
        {
            try
            {
                return await _cinemas.GetAsync(cinema => cinema.Id == cinemaId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
