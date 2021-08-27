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
            //_ucBookingByMemberCRUD.OnBoo
            //_dgvBookingByMemberCRUD.Enabled = false;
            // TODO: implement me
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdating()
        {
            // TODO: implement me
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceling()
        {
            // TODO: implement me
        }

        private void _ucBookingDetailsForm_BookingForAircraftCreated()
        {
            // TODO: implement me
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdated()
        {
            // TODO: implement me
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceled()
        {
            // TODO: implement me
        }
    }
}
