using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Get;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class Login : Form
    {
        private readonly ClientMainPage _clientMainPage;
        private readonly AdminMainPage _adminMainPage;
        private readonly IUserClient _userClient;
        public Login(ClientMainPage clientMainPage, AdminMainPage adminMainPage, IUserClient userClient)
        {
            InitializeComponent();
            _clientMainPage = clientMainPage;
            _adminMainPage = adminMainPage;
            _userClient = userClient;
        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {
            var request = new GetUserRequest()
            {
                Email = emailText.Text,
                Password = passwordText.Text
            };
            var user = await _userClient.GetUser(request);
            if (user.Role == UserType.Client)
            {
                _clientMainPage.User = user;
                PageHelper.Navigate(this, _clientMainPage);
            }
            else if (user.Role == UserType.Admin)
            {
                _adminMainPage.User = user;
                PageHelper.Navigate(this, _adminMainPage);
            }
        }
    }
}
