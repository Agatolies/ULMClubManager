using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms.Pages
{
    public partial class FormBookingByAircraft : Form
    {
        public FormBookingByAircraft()
        {
            InitializeComponent();
        }

        private void _ucBookingPickerByAircraft_SelectAircraftID(int aircraftID)
        {
            _ucBookingByAircraftCRUD.RefreshData(aircraftID);
        }

        private void _ucBookingByAircraftCRUD_SelectAircraft(DetailedBooking selectedBooking)
        {
            _ucBookingByAircraftDetailsForm.SelectedBooking = selectedBooking;
        }

        private void _ucBookingDetailsForm_BookingForAircraftCreating()
        {
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdating()
        {
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceling()
        {
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftCreated()
        {
            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdated()
        {
            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceled()
        {
            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
        }
    }
}
