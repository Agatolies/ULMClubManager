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
    public partial class FormBookingByMember : Form
    {
        public FormBookingByMember()
        {
            InitializeComponent();
        }

        private void _ucBookingPickerByPilot_SelectPilot(int memberID)
        {
            _ucBookingByMemberCRUD.RefreshData(memberID);
            _ucBookingByMemberDetailsForm.SelectedPilotID = memberID;
        }

        private void _ucBookingByMemberCRUD_SelectBooking(DetailedBooking selectedBooking)
        {
            _ucBookingByMemberDetailsForm.SelectedBooking = selectedBooking;
        }

        private void _ucBookingDetailsForm_BookingForMemberCreating()
        {
            _ucBookingByMemberPicker.Enabled = false;
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberUpdating()
        {
            _ucBookingByMemberPicker.Enabled = false;
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberCanceling()
        {
            _ucBookingByMemberPicker.Enabled = false;
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberCreated()
        {
            int index = _ucBookingByMemberPicker._lbPilots.SelectedIndex;
            _ucBookingByMemberPicker.InitializeData();
            _ucBookingByMemberPicker._lbPilots.SelectedIndex = index;

            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
            _ucBookingByMemberPicker.Enabled = true;
        }

        private void _ucBookingDetailsForm_BookingForMemberUpdated()
        {
            int index = _ucBookingByMemberPicker._lbPilots.SelectedIndex;
            _ucBookingByMemberPicker.InitializeData();
            _ucBookingByMemberPicker._lbPilots.SelectedIndex = index;

            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
            _ucBookingByMemberPicker.Enabled = true;
        }

        private void _ucBookingDetailsForm_BookingForMemberCanceled()
        {
            _ucBookingByMemberPicker.InitializeData();
            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
            _ucBookingByMemberPicker.Enabled = true;
        }
    }
}
