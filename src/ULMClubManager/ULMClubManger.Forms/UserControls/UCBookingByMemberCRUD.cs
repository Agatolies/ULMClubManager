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

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByMemberCRUD : UserControl
    {
        private List<DetailedBooking> _bookings;

        public UCBookingByMemberCRUD()
        {
            InitializeComponent();
            InitializeData();
        }

        public List<DetailedBooking> Bookings 
        {
            get 
            { 
                return _bookings;
            } 
            private set
            {
                _bookings = value;
                _bsBookings.DataSource = _bookings;
            }
        }

        private void InitializeData()
        {
            _bsAircrafts.DataSource = AircraftService.ReadAll();
        }

        public void RefreshData(int memberID)
        {
            Bookings = BookingService.ReadAllBookingByPilotID(memberID);
        }
    }
}
