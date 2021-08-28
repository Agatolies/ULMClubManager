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
        }

        private void _ucBookingByMemberCRUD_SelectBooking(DetailedBooking selectedBooking)
        {
            _ucBookingByMemberDetailsForm.SelectedBooking = selectedBooking;
        }

        private void _ucBookingDetailsForm_BookingForMemberCreating()
        {
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberUpdating()
        {
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberCanceling()
        {
            _ucBookingByMemberCRUD.DisableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberCreated()
        {
            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberUpdated()
        {
            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
        }

        private void _ucBookingDetailsForm_BookingForMemberCanceled()
        {
            _ucBookingByMemberCRUD.EnableDgvBookingByMember();
        }
    }
}
