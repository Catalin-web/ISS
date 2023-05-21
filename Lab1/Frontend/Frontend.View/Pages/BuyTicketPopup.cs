using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class BuyTicketPopup : Form
    {
        public User User { get; set; }
        public string CardId { get; set; }
        public string ProjectionId { get; set; }
        private readonly ITicketClient _ticketClient;
        private List<int> seats = new List<int>();
        public BuyTicketPopup(ITicketClient ticketClient)
        {
            InitializeComponent();
            _ticketClient = ticketClient;
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            seatGridView.ColumnCount = 1;
            seatGridView.Columns[0].Name = "Seat Number";
        }

        private void LoadSeats()
        {
            seatGridView.Rows.Clear();
            foreach (var seat in seats)
            {
                string seatNumber = seat.ToString();
                string[] row = { seatNumber };
                seatGridView.Rows.Add(row);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnFormClosing(e);
            PageHelper.Close(this);
        }

        private async void buyButton_Click(object sender, EventArgs e)
        {
            var request = new CreateTicketRequest()
            {
                UserId = User.Id,
                CardId = CardId,
                ProjectionId = ProjectionId,
                Seats = seats
            };
            await _ticketClient.CreateTicket(request);
            PageHelper.Close(this);
        }

        private void addSeat_Click(object sender, EventArgs e)
        {
            int newSeat = (int)numberSelector.Value;
            seats.Add(newSeat);
            LoadSeats();
        }
    }
}
