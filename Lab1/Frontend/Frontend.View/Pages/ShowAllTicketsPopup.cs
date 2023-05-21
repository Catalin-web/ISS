using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class ShowAllTicketsPopup : Form
    {
        public User User { get; set; }
        private readonly ITicketClient _ticketClient;
        private readonly ICinemaClient _cinemaClient;
        private readonly IMovieClient _movieClient;
        private readonly IProjectionClient _projectionClient;
        public ShowAllTicketsPopup(ITicketClient ticketClient, ICinemaClient cinemaClient, IMovieClient movieClient, IProjectionClient projectionClient)
        {
            InitializeComponent();
            _ticketClient = ticketClient;
            _cinemaClient = cinemaClient;
            _movieClient = movieClient;
            _projectionClient = projectionClient;
            InitializeTickets();
        }

        private void InitializeTickets()
        {
            ticketsGridView.ColumnCount = 8;
            ticketsGridView.Columns[0].Name = "Name";
            ticketsGridView.Columns[1].Name = "Type";
            ticketsGridView.Columns[2].Name = "Seat Number";
            ticketsGridView.Columns[3].Name = "Cinema Name";
            ticketsGridView.Columns[4].Name = "Cinema Location";
            ticketsGridView.Columns[5].Name = "Movie Name";
            ticketsGridView.Columns[6].Name = "Movie Duration";
            ticketsGridView.Columns[7].Name = "Date";
        }

        private async Task LoadTickets()
        {
            ticketsGridView.Rows.Clear();
            var tickets = await _ticketClient.GetAllTickets(User.Id);
            foreach (var ticket in tickets)
            {
                var projection = await _projectionClient.GetProjectionById(ticket.ProjectionId);
                var cinema = await _cinemaClient.GetCinemaById(projection.CinemaId);
                var movie = await _movieClient.GetMovieById(projection.MovieId);

                string userName = $"{User.FirstName} {User.LastName}";
                string type = ticket.Type == TicketType.RESERVED ? "RESERVED" : "BOUGHT";
                string seatNumber = ticket.SeatNumber.ToString();
                string cinemaName = cinema.Name;
                string cinemaLocation = cinema.Location;
                string movieName = movie.Name;
                string movieDuration = movie.DurationMinutes.ToString();
                string date = $"{projection.Date.Hour}:{projection.Date.Minute} {projection.Date.Day}/{projection.Date.Month}/{projection.Date.Year}";

                string[] row = { userName, type, seatNumber, cinemaName, cinemaLocation, movieName, movieDuration, date };
                ticketsGridView.Rows.Add(row);
            }
        }

        private async void loadTableButton_Click(object sender, EventArgs e)
        {
            await LoadTickets();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }
    }
}
