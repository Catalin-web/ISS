using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class AddMoviePage : Form
    {
        public User User { get; set; }
        private readonly IMovieClient _movieClient;
        public AddMoviePage(IMovieClient movieClient)
        {
            InitializeComponent();
            _movieClient = movieClient;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }

        private async void addMovieButton_Click(object sender, EventArgs e)
        {
            var request = new CreateMovieRequest()
            {
                UserId = User.Id,
                MovieName = nameText.Text,
                Duration = (int)durationNumber.Value
            };
            await _movieClient.CreateMovie(request);
            PageHelper.Close(this);
        }
    }
}
