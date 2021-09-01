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
            _ucBookingByAircraftPicker.Enabled = false;
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdating()
        {
            _ucBookingByAircraftPicker.Enabled = false;
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceling()
        {
            _ucBookingByAircraftPicker.Enabled = false;
            _ucBookingByAircraftCRUD.DisableDgvBookingByAircraft();
        }

        private void _ucBookingDetailsForm_BookingForAircraftCreated()
        {
            int index = _ucBookingByAircraftPicker._lbAircrafts.SelectedIndex;
            _ucBookingByAircraftPicker.InitializeData();
            _ucBookingByAircraftPicker._lbAircrafts.SelectedIndex = index;

            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
            _ucBookingByAircraftPicker.Enabled = true;
        }

        private void _ucBookingDetailsForm_BookingForAircraftUpdated()
        {
            int index = _ucBookingByAircraftPicker._lbAircrafts.SelectedIndex;
            _ucBookingByAircraftPicker.InitializeData();
            _ucBookingByAircraftPicker._lbAircrafts.SelectedIndex = index;

            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
            _ucBookingByAircraftPicker.Enabled = true;
        }

        private void _ucBookingDetailsForm_BookingForAircraftCanceled()
        {
            _ucBookingByAircraftPicker.InitializeData();
            _ucBookingByAircraftCRUD.EnableDgvBookingByAircraft();
            _ucBookingByAircraftPicker.Enabled = true;
        }
    }
}
