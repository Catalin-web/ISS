using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class FirstPage : Form
    {
        private readonly Register _loginPage;
        private readonly Login _registerPage;

        public FirstPage(Register loginPage, Login registerPage)
        {
            InitializeComponent();
            _loginPage = loginPage;
            _registerPage = registerPage;
        }

        private void register_Click(object sender, EventArgs e)
        {
            PageHelper.Navigate(this, _registerPage);
        }

        private void login_Click(object sender, EventArgs e)
        {
            PageHelper.Navigate(this, _loginPage);
        }
    }
}
