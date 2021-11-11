using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.Pages
{
    public partial class FormBookingFuture : Form
    {
        public FormBookingFuture()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            List<DetailedBooking> bookings = BookingService.ReadAllFutureBooking();

            _bsBookings.DataSource = bookings;
        }
    }
}
