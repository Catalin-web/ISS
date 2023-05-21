using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Delete;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class DeleteReservationPage : Form
    {
        public User User { get; set; }
        private readonly ITicketClient _ticketClient;
        private readonly IReservationClient _reservationClient;
        private readonly ICinemaClient _cinemaClient;
        private readonly IMovieClient _movieClient;
        private readonly IProjectionClient _projectionClient;
        public DeleteReservationPage(ITicketClient ticketClient, IReservationClient reservationClient, ICinemaClient cinemaClient, IMovieClient movieClient, IProjectionClient projectionClient)
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
            reservationDataGrid.ColumnCount = 8;
            reservationDataGrid.Columns[0].Name = "Name";
            reservationDataGrid.Columns[1].Name = "Seat Number";
            reservationDataGrid.Columns[2].Name = "Cinema Name";
            reservationDataGrid.Columns[3].Name = "Cinema Location";
            reservationDataGrid.Columns[4].Name = "Movie Name";
            reservationDataGrid.Columns[5].Name = "Movie Duration";
            reservationDataGrid.Columns[6].Name = "Date";
            reservationDataGrid.Columns[7].Name = "ID";
        }

        private async Task LoadReservations()
        {
            reservationDataGrid.Rows.Clear();
            var reservations = await _reservationClient.GetAll();
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
                string id = reservation.Id;

                string[] row = { userName, seatNumber, cinemaName, cinemaLocation, movieName, movieDuration, date, id };
                reservationDataGrid.Rows.Add(row);
            }
        }

        private string GetSelectedId()
        {
            if(reservationDataGrid.SelectedRows.Count != 1)
            {
                return null;
            }
            return (string)reservationDataGrid.SelectedRows[0].Cells[7].Value;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }

        private async void loadReservationButton_Click(object sender, EventArgs e)
        {
            await LoadReservations();
        }

        private async void deleteSelectedReservationButton_Click(object sender, EventArgs e)
        {
            var request = new DeleteReservationRequest()
            {
                UserId = User.Id,
                ReservationId = GetSelectedId()
            };
            await _reservationClient.DeleteReservation(request);
        }
    }
}
