using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;


namespace Frontend.Views.Pages
{
    public partial class AddProjectionPage : Form
    {
        public User User { get; set; }
        private readonly IMovieClient _movieClient;
        private readonly ICinemaClient _cinemaClient;
        private readonly IProjectionClient _projectionClient;
        public AddProjectionPage(IMovieClient movieClient, ICinemaClient cinemaClient, IProjectionClient projectionClient)
        {
            InitializeComponent();
            _movieClient = movieClient;
            _cinemaClient = cinemaClient;
            _projectionClient = projectionClient;
            InitializeMovies();
            InitializeCinemas();
        }

        private void InitializeCinemas()
        {
            cinemaDataGrid.ColumnCount = 3;
            cinemaDataGrid.Columns[0].Name = "Name";
            cinemaDataGrid.Columns[1].Name = "Total Number Of Seats";
            cinemaDataGrid.Columns[2].Name = "Location";
        }

        private async Task LoadCinemas()
        {
            cinemaDataGrid.Rows.Clear();
            var cinemas = await _cinemaClient.GetAllCinemas();
            foreach (var cinema in cinemas)
            {
                string name = cinema.Name;
                string totalNumberOfSeats = cinema.TotalNumberOfSeats.ToString();
                string location = cinema.Location;
                string[] row = { name, totalNumberOfSeats, location };
                cinemaDataGrid.Rows.Add(row);
            }
        }

        private string GetSelectedCinemaName()
        {
            if (cinemaDataGrid.SelectedRows?.Count != 1)
            {
                return null;
            }
            return cinemaDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void InitializeMovies()
        {
            moviesDataGrid.ColumnCount = 2;
            moviesDataGrid.Columns[0].Name = "Name";
            moviesDataGrid.Columns[1].Name = "Duration (Minutes)";
        }

        private async Task LoadMovies()
        {
            moviesDataGrid.Rows.Clear();
            var movies = await _movieClient.GetAllMovies();
            foreach (var movie in movies)
            {
                string name = movie.Name;
                string duration = movie.DurationMinutes.ToString();
                string[] row = { name, duration };
                moviesDataGrid.Rows.Add(row);
            }
        }

        private string GetSelectedMovieName()
        {
            if (moviesDataGrid.SelectedRows?.Count != 1)
            {
                return null;
            }
            return moviesDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }

        private async void loadMoviesButton_Click(object sender, EventArgs e)
        {
            await LoadMovies();
        }

        private async void loadCinemasButton_Click(object sender, EventArgs e)
        {
            await LoadCinemas();
        }

        private async void addProjectionButton_Click(object sender, EventArgs e)
        {
            var request = new CreateProjectionRequest()
            {
                UserId = User.Id,
                CinemaName = GetSelectedCinemaName(),
                MovieName = GetSelectedMovieName(),
                Date = new Date()
                {
                    Minute = (int)minuteNumber.Value,
                    Hour = (int)hourNumber.Value,
                    Day = (int)dayNumber.Value,
                    Month = (int)monthNumber.Value,
                    Year = (int)yearNumber.Value
                }
            };
            await _projectionClient.CreateProjection(request);
            PageHelper.Close(this);
        }
    }
}
