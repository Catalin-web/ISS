using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class Register : Form
    {
        private readonly ClientMainPage _clientMainPage;
        private readonly AdminMainPage _adminMainPage;
        public readonly IUserClient _userClient;
        public Register(ClientMainPage clientMainPage, AdminMainPage adminMainPage, IUserClient userClient)
        {
            InitializeComponent();
            _clientMainPage = clientMainPage;
            _adminMainPage = adminMainPage;
            _userClient = userClient;
        }

        private async void registerButton_ClickAsync(object sender, EventArgs e)
        {
            var request = new CreateUserRequest()
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Email = emailText.Text,
                Password = passwordText.Text
            };
            var user = await _userClient.CreateUser(request);
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
