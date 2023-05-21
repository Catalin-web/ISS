using Frontend.Models.Entities;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class AdminMainPage : Form
    {
        public User User { get; set; }
        private readonly AddMoviePage _addMoviePage;
        private readonly AddCinemaPage _addCinemaPage;
        private readonly AddProjectionPage _addProjectionPage;
        private readonly DeleteReservationPage _deleteReservationPage;
        public AdminMainPage(AddMoviePage addMoviePage, AddCinemaPage addCinemaPage, AddProjectionPage addProjectionPage, DeleteReservationPage deleteReservationPage)
        {
            InitializeComponent();
            _addMoviePage = addMoviePage;
            _addCinemaPage = addCinemaPage;
            _addProjectionPage = addProjectionPage;
            _deleteReservationPage = deleteReservationPage;
        }

        private void addCinemaButton_Click(object sender, EventArgs e)
        {
            _addCinemaPage.User = User;
            PageHelper.Open(_addCinemaPage);
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            _addMoviePage.User = User;
            PageHelper.Open(_addMoviePage);
        }

        private void addProjectionButton_Click(object sender, EventArgs e)
        {
            _addProjectionPage.User = User;
            PageHelper.Open(_addProjectionPage);
        }

        private void deleteReservationsButton_Click(object sender, EventArgs e)
        {
            _deleteReservationPage.User = User;
            PageHelper.Open(_deleteReservationPage);
        }
    }
}
