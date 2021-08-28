using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULMClubManager.BL;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Enums;
using ULMClubManager.DTO.Exceptions;
using ULMClubManager.DTO.Helpers;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByMemberDetailsForm : UCBookingBase, IUCBooking
    {
        public event delBookingForMemberCreating BookingForMemberCreating;
        public event delBookingForMemberUpdating BookingForMemberUpdating;
        public event delBookingForMemberCanceling BookingForMemberCanceling;

        public event delBookingForMemberCreated BookingForMemberCreated;
        public event delBookingForMemberUpdated BookingForMemberUpdated;
        public event delBookingForMemberCanceled BookingForMemberCanceled;

        public UCBookingByMemberDetailsForm()
        {
            InitializeComponent();
            InitializeData();
        }

        public DetailedBooking SelectedBooking
        {
            get { return _selectedBooking; }
            set
            {
                if (value != null)
                {
                    _selectedBooking = value;

                    _btnFooterBookingByMemberUpdate.Visible = true;
                    _btnFooterBookingByMemberCancel.Visible = true;

                    RefreshDetailsForm();
                }
                else
                {
                    _cboxBookingByMember_MemberName.SelectedIndex = -1;

                    _btnFooterBookingByMemberUpdate.Visible = false;
                    _btnFooterBookingByMemberCancel.Visible = false;

                    ClearControls();
                }
            }
        }

        private new void InitializeData()
        {
            base.InitializeData();

            _cboxBookingByMember_TimeSlotStart.DataSource = _timeSlotsStart;
            _cboxBookingByMember_TimeSlotEnd.DataSource = _timeSlotsEnd;
            _cboxBookingByMember_Runway.DataSource = _allRunways;

            _cboxBookingByMember_Aircraft.DisplayMember = "Registration";
            _cboxBookingByMember_Aircraft.ValueMember = "ID";
            _cboxBookingByMember_Runway.DisplayMember = "ID";
            _cboxBookingByMember_Runway.ValueMember = "ID";
            _cboxBookingByMember_MemberName.DisplayMember = "FullName";
            _cboxBookingByMember_MemberName.ValueMember = "ID";

            _bsPilots.DataSource = _allPilots;
            _bsAircrafts.DataSource = _allAircrafts;
            _bsRunways.DataSource = _allRunways;

            _panelBookingByMBR_Details.Visible = false;
            _panelBookingByMember_Details.Visible = false;

            //if (BookingService.ReadAllBookingByPilotID(SelectedPilotID) == null)
            //{
            //    _btnFooterBookingByMemberUpdate.Visible = false;
            //    _btnFooterBookingByMemberCancel.Visible = false;
            //}
        }

        public void ShowErrorMessage(BusinessException ex)
        {
            string decoded = Rules.MessageDecoder(ex);

            _labelBookingByMBR_ErrorMessage.Text = decoded;
            _labelBookingByMBR_ErrorMessage.Visible = true;
        }

        public void ShowErrorMessage(Exception ex)
        {
            string decoded = Rules.MessageDecoder(ContextError.RES, ex.Message);

            _labelBookingByMBR_ErrorMessage.Text = decoded;
            _labelBookingByMBR_ErrorMessage.Visible = true;
        }

        public void HideErrorMessage()
        {
            _labelBookingByMBR_ErrorMessage.Text = "";
            _labelBookingByMBR_ErrorMessage.Visible = false;
        }

        public void RefreshTimeSlotsEnd()
        {
            // On récupère l'heure de début
            TimeSpan startTimeSlot = (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedValue;
            List<TimeSpan> timeSlots = GetMaximumBookingHours(startTimeSlot);

            _cboxBookingByMember_TimeSlotEnd.DataSource = timeSlots;
        }

        public void RefreshDetailsForm()
        {
            _cboxBookingByMember_Aircraft.SelectedValue = SelectedBooking.AircraftID;
            _dtpBookingByMember_Date.Value = SelectedBooking.Date;
            _cboxBookingByMember_TimeSlotStart.SelectedItem = SelectedBooking.StartHour;
            _cboxBookingByMember_TimeSlotEnd.SelectedItem = SelectedBooking.EndHour;
            _cboxBookingByMember_Runway.SelectedValue = SelectedBooking.RunwayID;
        }

        public void ClearControls()
        {
            _cboxBookingByMember_Aircraft.SelectedValue = -1;
            _dtpBookingByMember_Date.Value = DateTime.Now;
            _cboxBookingByMember_TimeSlotStart.DataSource = TimeSlot.GetTimeSlots();
            _cboxBookingByMember_Runway.SelectedValue = -1;
        }

        public void LockControls()
        {
            _cboxBookingByMember_Aircraft.Enabled = false;
            _dtpBookingByMember_Date.Enabled = false;
            _cboxBookingByMember_TimeSlotStart.Enabled = false;
            _cboxBookingByMember_TimeSlotEnd.Enabled = false;
            _cboxBookingByMember_Runway.Enabled = false;
        }

        public void UnlockControls()
        {
            _cboxBookingByMember_Aircraft.Enabled = true;
            _dtpBookingByMember_Date.Enabled = true;
            _cboxBookingByMember_TimeSlotStart.Enabled = true;
            _cboxBookingByMember_TimeSlotEnd.Enabled = true;
            _cboxBookingByMember_Runway.Enabled = true;
        }

        public Booking GetEditedBooking()
        {
            return new Booking(
                _dtpBookingByMember_Date.Value,
                (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByMember_TimeSlotEnd.SelectedItem,
                "",
                null,
                null,
                SelectedPilotID,
                ((Aircraft)_cboxBookingByMember_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByMember_Runway.SelectedItem).ID.Value);
        }

        // Ajout d'une réservation

        private void _btnFooterBookingByMemberCreate_Click(object sender, EventArgs e)
        {
            _labelBookingByMBR_DetailsTitle.Text = "NOUVELLE RESERVATION";

            _panelFooterBookingByMemberCRUD.Visible = false;
            _panelFooterBookingByMember_Create.Visible = true;
            _panelBookingByMBR_Details.Visible = true;

            _bookingBackup = SelectedBooking?.CreateDeepCopy();

            _cboxBookingByMember_MemberName.SelectedItem = SelectedPilot;

            _dtpBookingByMember_Date.Value = DateTime.Now;

            this.BookingForMemberCreating();

            UnlockControls();
            ClearControls();
        }

        private void _btnFooterBookingByMember_CreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking = GetEditedBooking();

                BookingService.CreateOne(booking);

                _bookingBackup = null;

                //RefreshData(_selectedBooking.MemberID);
                HideErrorMessage();
                LockControls();

                _panelFooterBookingByMember_Create.Visible = false;
                _panelFooterBookingByMemberCRUD.Visible = true;
                _panelBookingByMBR_Details.Visible = false;

                this.BookingForMemberCreated();

                ShowCreateBookingConfirmation(SelectedPilot.FullName);
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void _btnFooterBookingByMember_CreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ShowCancelBookingCreation();

            if (dialogResult == DialogResult.Yes)
            {
                SelectedBooking = _bookingBackup;
                _bookingBackup = null;

                LockControls();
                HideErrorMessage();

                _panelFooterBookingByMember_Create.Visible = false;
                _panelFooterBookingByMemberCRUD.Visible = true;
                _panelBookingByMBR_Details.Visible = false;

                this.BookingForMemberCreated();
            }
        }

        // Modification d'une réservation

        private void _btnFooterBookingByMemberUpdate_Click(object sender, EventArgs e)
        {
            _labelBookingByMBR_DetailsTitle.Text = "MODIFICATION DE LA RESERVATION";

            _panelFooterBookingByMemberCRUD.Visible = false;
            _panelFooterBookingByMember_Update.Visible = true;
            _panelBookingByMBR_Details.Visible = true;

            _cboxBookingByMember_MemberName.SelectedItem = SelectedPilot;

            this.BookingForMemberUpdating();

            UnlockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByMember_UpdateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking = GetEditedBooking();

                BookingService.UpdateOne(booking);

                _bookingBackup = null;

                HideErrorMessage();
                LockControls();
                //RefreshData(_selectedBooking.MemberID);

                _panelFooterBookingByMember_Update.Visible = false;
                _panelFooterBookingByMemberCRUD.Visible = true;
                _panelBookingByMBR_Details.Visible = false;

                this.BookingForMemberUpdated();

                MessageBox.Show(
                    $"La réservation pour {SelectedBooking.MemberFullName} a bien été mise à jour.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void _btnFooterBookingByMember_UpdateDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler la modification en cours ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                LockControls();
                HideErrorMessage();

                _panelFooterBookingByMember_Update.Visible = false;
                _panelFooterBookingByMemberCRUD.Visible = true;
                _panelBookingByMBR_Details.Visible = false;

                this.BookingForMemberUpdated();
            }
        }

        // Annulation d'une réservation

        private void _btnFooterBookingByMemberCancel_Click(object sender, EventArgs e)
        {
            _labelBookingByMBR_CancellationReason.Visible = true;
            _labelBookingByMBR_DetailsTitle.Text = "ANNULATION DE LA RESERVATION";

            _panelBookingByMBR_Details.Visible = true;
            _panelFooterBookingByMember_Cancel.Visible = true;
            _panelFooterBookingByMemberCRUD.Visible = false;

            _tboxBookingByMBR_CancellationReason.Visible = true;

            this.BookingForMemberCanceling();

            LockControls();

            _bookingBackup = SelectedBooking.CreateDeepCopy();
        }

        private void _btnFooterBookingByMember_CancelConfirm_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous vraiment annuler cette réservation ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    CancellationService.CreateOneCancellation(SelectedBooking.ID.Value, _tboxBookingByMBR_CancellationReason.Text);

                    _bookingBackup = null;

                    //RefreshData(_selectedBooking.MemberID);
                    HideErrorMessage();

                    _labelBookingByMBR_CancellationReason.Visible = false;

                    _panelBookingByMBR_Details.Visible = false;
                    _panelFooterBookingByMember_Cancel.Visible = false;
                    _panelFooterBookingByMemberCRUD.Visible = true;

                    _tboxBookingByMBR_CancellationReason.Visible = false;

                    this.BookingForMemberCanceled();
                }
            }
            catch (BusinessException ex)
            {
                ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex);
            }
        }

        private void _btnFooterBookingByMember_CancelCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler l'opération en cours ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                LockControls();
                HideErrorMessage();

                SelectedBooking = _bookingBackup;
                _bookingBackup = null;

                _labelBookingByMBR_CancellationReason.Visible = false;

                _panelFooterBookingByMember_Update.Visible = false;
                _panelFooterBookingByMember_Cancel.Visible = false;
                _panelFooterBookingByMemberCRUD.Visible = true;
                _panelBookingByMBR_Details.Visible = false;

                _tboxBookingByMBR_CancellationReason.Visible = false;

                this.BookingForMemberCanceled();
            }
        }

        private void _cboxBookingByMember_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }

    }
}
