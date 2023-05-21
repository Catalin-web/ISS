using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Get;
using Frontend.Views.Utils;
using SerFrontendver.Models.Requests.Get;

namespace Frontend.Views.Pages
{
    public partial class ClientMainPage : Form
    {
        public User User { get; set; }
        private readonly CreateCardPopup _createCardPopup;
        private readonly ReservatePopup _reservatePopup;
        private readonly BuyTicketPopup _buyTicketPopup;
        private readonly ShowAllTicketsPopup _showTicketPopup;
        private readonly ShowAllReservationsPopup _showReservattionPopup;
        private readonly IMovieClient _movieClient;
        private readonly ICinemaClient _cinemaClient;
        private readonly IProjectionClient _projectionClient;
        private readonly ICardClient _cardClient;

        public ClientMainPage(CreateCardPopup createCardPopup, ReservatePopup reservatePopup, BuyTicketPopup buyPopup, ShowAllTicketsPopup showTicketPopup, ShowAllReservationsPopup showReservattionPopup, IMovieClient movieClient, ICinemaClient cinemaClient, IProjectionClient projectionClient, ICardClient cardClient)
        {
            InitializeComponent();
            _createCardPopup = createCardPopup;
            _reservatePopup = reservatePopup;
            _buyTicketPopup = buyPopup;
            _showTicketPopup = showTicketPopup;
            _showReservattionPopup = showReservattionPopup;
            _movieClient = movieClient;
            _cinemaClient = cinemaClient;
            _projectionClient = projectionClient;
            _cardClient = cardClient;
            InitializeMovies();
            InitializeCinemas();
            InitializeProjections();
            Initializecards();
        }

        private void InitializeCinemas()
        {
            cinemaGridView.ColumnCount = 3;
            cinemaGridView.Columns[0].Name = "Name";
            cinemaGridView.Columns[1].Name = "Total Number Of Seats";
            cinemaGridView.Columns[2].Name = "Location";
        }

        private async Task LoadCinemas()
        {
            cinemaGridView.Rows.Clear();
            var cinemas = await _cinemaClient.GetAllCinemas();
            foreach (var cinema in cinemas)
            {
                string name = cinema.Name;
                string totalNumberOfSeats = cinema.TotalNumberOfSeats.ToString();
                string location = cinema.Location;
                string[] row = { name, totalNumberOfSeats, location };
                cinemaGridView.Rows.Add(row);
            }
        }

        private string GetSelectedCinemaName()
        {
            if (cinemaGridView.SelectedRows?.Count != 1)
            {
                return null;
            }
            return cinemaGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void InitializeMovies()
        {
            movieGridView.ColumnCount = 2;
            movieGridView.Columns[0].Name = "Name";
            movieGridView.Columns[1].Name = "Duration (Minutes)";
        }

        private async Task LoadMovies()
        {
            movieGridView.Rows.Clear();
            var movies = await _movieClient.GetAllMovies();
            foreach (var movie in movies)
            {
                string name = movie.Name;
                string duration = movie.DurationMinutes.ToString();
                string[] row = { name, duration };
                movieGridView.Rows.Add(row);
            }
        }

        private string GetSelectedMovieName()
        {
            if (movieGridView.SelectedRows?.Count != 1)
            {
                return null;
            }
            return movieGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void InitializeProjections()
        {
            projectionGridView.ColumnCount = 6;
            projectionGridView.Columns[0].Name = "Minute";
            projectionGridView.Columns[1].Name = "Hour";
            projectionGridView.Columns[2].Name = "Day";
            projectionGridView.Columns[3].Name = "Month";
            projectionGridView.Columns[4].Name = "Year";
            projectionGridView.Columns[5].Name = "ID";
        }

        private async Task LoadProjection()
        {
            projectionGridView.Rows.Clear();
            string cinemaName = GetSelectedCinemaName();
            if (cinemaName == null)
            {
                return;
            }
            string movieName = GetSelectedMovieName();
            var projections = new List<Projection>();
            if (movieName != null)
            {
                var request = new GetAllProjectionOfMovieRequest()
                {
                    CinemaName = cinemaName,
                    MovieName = movieName,
                };
                projections = await _projectionClient.GetAllPRojectionByMovie(request);
            }
            else
            {
                var request = new GetAllProjectionOfCinemaRequest()
                {
                    CinemaName = cinemaName
                };
                projections = await _projectionClient.GetAllProjectionByCinema(request);
            }
            foreach (var projection in projections)
            {
                var date = projection.Date;
                var minute = date.Minute.ToString();
                var hour = date.Hour.ToString();
                var day = date.Day.ToString();
                var month = date.Month.ToString();
                var year = date.Year.ToString();
                var id = projection.Id;
                string[] row = { minute, hour, day, month, year, id };
                projectionGridView.Rows.Add(row);
            }
        }

        private string GetSelectedProjectionId()
        {
            if (projectionGridView.SelectedRows.Count != 1)
            {
                return null;
            }
            return (string)projectionGridView.SelectedRows[0].Cells[5].Value;
        }

        private void Initializecards()
        {
            cardGridView.ColumnCount = 4;
            cardGridView.Columns[0].Name = "Number";
            cardGridView.Columns[1].Name = "Series";
            cardGridView.Columns[2].Name = "Cvv";
            cardGridView.Columns[3].Name = "ID";
        }

        private async Task LoadCards()
        {
            cardGridView.Rows.Clear();
            var cards = await _cardClient.GetCards(User.Id);
            foreach (var card in cards)
            {
                string number = card.Number;
                string series = card.Series;
                string cvv = card.Cvv;
                string id = card.Id;
                string[] row = { number, series, cvv, id };
                cardGridView.Rows.Add(row);
            }
        }

        private string GetSelectedCardId()
        {
            if (cardGridView.SelectedRows.Count != 1)
            {
                return null;
            }
            return (string)cardGridView.SelectedRows[0].Cells[3].Value;
        }

        private async void searchCinema_Click(object sender, EventArgs e)
        {
            await LoadCinemas();
        }

        private async void searchMovies_Click(object sender, EventArgs e)
        {
            await LoadMovies();
        }

        private async void searchProjections_Click(object sender, EventArgs e)
        {
            await LoadProjection();
        }

        private async void searchCards_Click(object sender, EventArgs e)
        {
            await LoadCards();
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            _createCardPopup.User = User;
            PageHelper.Open(_createCardPopup);
        }

        private async void bookButton_Click(object sender, EventArgs e)
        {
            _reservatePopup.User = User;
            _reservatePopup.ProjectionId = GetSelectedProjectionId();
            PageHelper.Open(_reservatePopup);
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            _buyTicketPopup.User = User;
            _buyTicketPopup.ProjectionId = GetSelectedProjectionId();
            _buyTicketPopup.CardId = GetSelectedCardId();
            PageHelper.Open(_buyTicketPopup);
        }

        private void showAllTicketsButton_Click(object sender, EventArgs e)
        {
            _showTicketPopup.User = User;
            PageHelper.Open(_showTicketPopup);
        }

        private void showReservationButton_Click(object sender, EventArgs e)
        {
            _showReservattionPopup.User = User;
            PageHelper.Open(_showReservattionPopup);
        }
    }
}
