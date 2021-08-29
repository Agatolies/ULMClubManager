using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
