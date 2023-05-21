using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class AddCinemaPage : Form
    {
        public User User { get; set; }
        private readonly ICinemaClient _cinemaClient;
        public AddCinemaPage(ICinemaClient cinemaClient)
        {
            InitializeComponent();
            _cinemaClient = cinemaClient;
        }

        private async void addCinemaButton_Click(object sender, EventArgs e)
        {
            var request = new CreateCinemaRequest()
            {
                UserId = User.Id,
                CinemaName = nameText.Text,
                CinemaTotalNumberOfSeats = totalNumberOfSeatsNumber.Value.ToString(),
                CinemaLocation = locationText.Text
            };
            await _cinemaClient.CreateCinema(request);
            PageHelper.Close(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }
    }
}
