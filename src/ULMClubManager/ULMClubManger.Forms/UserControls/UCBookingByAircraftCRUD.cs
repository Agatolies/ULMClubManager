using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByAircraftCRUD : UserControl
    {
        public event delSelectAircraft SelectAircraft;

        private List<DetailedBooking> _bookings;
        private List<DetailedBooking> _cancellations;

        public UCBookingByAircraftCRUD()
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

        public void RefreshData(int aircraftID)
        {
            List<DetailedBooking> detailedBookings = BookingService.ReadAllBookingByAircraftID(aircraftID);

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
            // Utilisation du délégué pour notifier le UCBookingByAircraftDetailsForm
            // J'envoie le message "j'ai selectionne la reservation dont tu as besoin"

            if (this.SelectAircraft != null && _bsBookings.Current != null)
            {
                DetailedBooking selectedAircraft = (DetailedBooking)_bsBookings.Current;
                this.SelectAircraft(selectedAircraft);

                this.BookingID = selectedAircraft.ID.Value;
                this.MemberID = selectedAircraft.MemberID;
            }
            else
            {
                this.SelectAircraft(null);
            }
        }

        public void EnableDgvBookingByAircraft()
        {
            _dgvBookingByAircraftCRUD.Enabled = true;
        }

        public void DisableDgvBookingByAircraft()
        {
            _dgvBookingByAircraftCRUD.Enabled = false;
        }

        private void _dgvBookingByAircraftCRUD_SelectionChanged(object sender, EventArgs e)
        {
            OnSelectBooking();
        }
    }
}
