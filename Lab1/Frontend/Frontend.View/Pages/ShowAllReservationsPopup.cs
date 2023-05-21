using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class ShowAllReservationsPopup : Form
    {
        public User User { get; set; }
        private readonly ITicketClient _ticketClient;
        private readonly IReservationClient _reservationClient;
        private readonly ICinemaClient _cinemaClient;
        private readonly IMovieClient _movieClient;
        private readonly IProjectionClient _projectionClient;
        public ShowAllReservationsPopup(ITicketClient ticketClient, IReservationClient reservationClient, ICinemaClient cinemaClient, IMovieClient movieClient, IProjectionClient projectionClient)
        {
            InitializeComponent();
            _ticketClient = ticketClient;
            _reservationClient = reservationClient;
            _cinemaClient = cinemaClient;
            _movieClient = movieClient;
            _projectionClient = projectionClient;
            InitializeReservations();
        }

        private void InitializeReservations()
        {
            ticketsGridView.ColumnCount = 7;
            ticketsGridView.Columns[0].Name = "Name";
            ticketsGridView.Columns[1].Name = "Seat Number";
            ticketsGridView.Columns[2].Name = "Cinema Name";
            ticketsGridView.Columns[3].Name = "Cinema Location";
            ticketsGridView.Columns[4].Name = "Movie Name";
            ticketsGridView.Columns[5].Name = "Movie Duration";
            ticketsGridView.Columns[6].Name = "Date";
        }

        private async Task LoadTickets()
        {
            ticketsGridView.Rows.Clear();
            var reservations = await _reservationClient.GetAllReservations(User.Id);
            foreach (var reservation in reservations)
            {
                var ticket = await _ticketClient.GetTicketById(reservation.TicketId);
                var projection = await _projectionClient.GetProjectionById(ticket.ProjectionId);
                var cinema = await _cinemaClient.GetCinemaById(projection.CinemaId);
                var movie = await _movieClient.GetMovieById(projection.MovieId);

                string userName = $"{User.FirstName} {User.LastName}";
                string seatNumber = ticket.SeatNumber.ToString();
                string cinemaName = cinema.Name;
                string cinemaLocation = cinema.Location;
                string movieName = movie.Name;
                string movieDuration = movie.DurationMinutes.ToString();
                string date = $"{projection.Date.Hour}:{projection.Date.Minute} {projection.Date.Day}/{projection.Date.Month}/{projection.Date.Year}";

                string[] row = { userName, seatNumber, cinemaName, cinemaLocation, movieName, movieDuration, date };
                ticketsGridView.Rows.Add(row);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }

        private async void loadTableButton_Click(object sender, EventArgs e)
        {
            await LoadTickets();

        }
    }
}
