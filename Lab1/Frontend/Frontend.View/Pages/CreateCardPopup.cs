using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;
using System.ComponentModel;

namespace Frontend.Views.Pages
{
    public partial class CreateCardPopup : Form
    {
        public User User { get; set; }
        private ICardClient _cardClient;

        public CreateCardPopup(ICardClient cardClient)
        {
            InitializeComponent();
            _cardClient = cardClient;
            FormClosing += OnFormClosing;
        }

        private async void addCardButton_Click(object sender, EventArgs e)
        {
            var request = new CreateCardRequest()
            {
                UserId = User.Id,
                CardNumber = numberText.Text,
                CardSeries = seriesText.Text,
                CardCvv = cvvText.Text,
            };
            await _cardClient.CreateCard(request);
            PageHelper.Close(this);
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }
    }
}
