using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByMemberCRUD : UserControl
    {
        public event delSelectBooking SelectBooking;

        private List<DetailedBooking> _bookings;
        private List<DetailedBooking> _cancellations;

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

        public List<DetailedBooking> Cancellations
        {
            get
            {
                return _cancellations;
            }
            private set
            {
                _cancellations = value;
                _bsCancellations.DataSource = _cancellations;
            }
        }

        public int BookingID { get; private set; }
        public int MemberID { get; private set; }

        private void InitializeData()
        {
            List<Cancellation> cancellations = CancellationService.ReadAllCancellations();

            _bsCancellations.DataSource = cancellations;
        }

        public void RefreshData(int memberID)
        {
            List<DetailedBooking> detailedBookings = BookingService.ReadAllBookingByPilotID(memberID);
            
            Bookings = detailedBookings
                .Where(booking => string.IsNullOrEmpty(booking.CancellationReason))
                .ToList();

            Cancellations = detailedBookings
                .Where(booking => !string.IsNullOrEmpty(booking.CancellationReason))
                .ToList();

            foreach (DetailedBooking can in Cancellations)
                Bookings.Remove(can);
        }

        private void ClearData()
        {
            _bsBookings.Clear();
        }

        private void OnSelectBooking()
        {
            // Utilisation du délégué pour notifier le UCBookingByMemberDetailsForm
            // J'envoie le message "j'ai selectionne la reservation dont tu as besoin"

            if (this.SelectBooking != null && _bsBookings.Current != null)
            {
                DetailedBooking selectedBooking = (DetailedBooking)_bsBookings.Current;
                this.SelectBooking(selectedBooking);

                this.BookingID = selectedBooking.ID.Value;
                this.MemberID = selectedBooking.MemberID;
            }
            else
            {
                this.SelectBooking(null);
            }
        }

        public void EnableDgvBookingByMember()
        {
            _dgvBookingByMember.Enabled = true;
        }

        public void DisableDgvBookingByMember()
        {
            _dgvBookingByMember.Enabled = false;
        }

        private void _dgvBookingByMemberCRUD_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectBooking();
        }
    }
}
