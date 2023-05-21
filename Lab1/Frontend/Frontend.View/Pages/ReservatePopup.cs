using Frontend.Client;
using Frontend.Models.Entities;
using Frontend.Models.Requests.Create;
using Frontend.Views.Utils;

namespace Frontend.Views.Pages
{
    public partial class ReservatePopup : Form
    {
        public User User { get; set; }
        public string ProjectionId { get; set; }
        private readonly IReservationClient _reservationClient;
        private List<int> seats = new List<int>();
        public ReservatePopup(IReservationClient reservationClient)
        {
            InitializeComponent();
            _reservationClient = reservationClient;
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

        private void addSeat_Click(object sender, EventArgs e)
        {
            int newSeat = (int)numberSelector.Value;
            seats.Add(newSeat);
            LoadSeats();
        }

        private async void reservateButton_Click(object sender, EventArgs e)
        {
            var request = new CreateReservationRequest()
            {
                UserId = User.Id,
                ProjectionId = ProjectionId,
                Seats = seats
            };
            await _reservationClient.CreateReservation(request);
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
