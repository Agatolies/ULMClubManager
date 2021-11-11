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

            _cboxBookingByMember_Aircraft.DisplayMember = "Registration";
            _cboxBookingByMember_Aircraft.ValueMember = "ID";
            _cboxBookingByMember_Runway.DisplayMember = "ID";
            _cboxBookingByMember_Runway.ValueMember = "ID";
            _cboxBookingByMember_MemberName.DisplayMember = "FullName";
            _cboxBookingByMember_MemberName.ValueMember = "ID";

            _bsAircrafts.DataSource = _allAircrafts;
            _bsPilots.DataSource = _allPilots;
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
            _labelBookingByMBR_ErrorMessage.Text = Rules.MessageDecoder(ex);
            _labelBookingByMBR_ErrorMessage.Visible = true;
        }

        public void ShowErrorMessage(Exception ex)
        {
            _labelBookingByMBR_ErrorMessage.Text = Rules.MessageDecoder(ContextError.RES, ex.Message);
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
            _cboxBookingByMember_TimeSlotEnd.DataSource = GetMaximumBookingHours(startTimeSlot);
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
            _tboxBookingByMBR_CancellationReason.Text = "";
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

        public Booking GetCreatingBooking()
        {
            return new Booking(
                _dtpBookingByMember_Date.Value,
                (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByMember_TimeSlotEnd.SelectedItem,
                null,
                null,
                null,
                ((Member)_cboxBookingByMember_MemberName.SelectedItem).ID.Value,
                ((Aircraft)_cboxBookingByMember_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByMember_Runway.SelectedItem).ID.Value);
        }

        public Booking GetUpdatingBooking()
        {
            return new Booking(
                SelectedBooking.ID,
                _dtpBookingByMember_Date.Value,
                (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByMember_TimeSlotEnd.SelectedItem,
                null,
                null,
                null,
                ((Member)_cboxBookingByMember_MemberName.SelectedItem).ID.Value,
                ((Aircraft)_cboxBookingByMember_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByMember_Runway.SelectedItem).ID.Value);
        }

        private bool DetectUnfilledFields()
        {
            bool isMemberNameNotFilled = _cboxBookingByMember_MemberName.SelectedIndex == -1;
            bool isAircraftNotFilled = _cboxBookingByMember_Aircraft.SelectedIndex == -1;
            bool isRunwayNotFilled = _cboxBookingByMember_Runway.SelectedIndex == -1;
            return isMemberNameNotFilled || isAircraftNotFilled || isRunwayNotFilled;
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

            BookingForMemberCreating();

            UnlockControls();
            ClearControls();
        }

        private void _btnFooterBookingByMember_CreateConfirm_Click(object sender, EventArgs e)
        {
            bool hasError = DetectUnfilledFields();

            if (hasError)
            {
                MessageBoxHelper.ShowMandatoryDataError();
            }
            else
            {
                try
                {
                    Booking booking = GetCreatingBooking();
                    BookingService.CreateOne(booking);

                    _bookingBackup = null;

                    HideErrorMessage();
                    LockControls();

                    Member member = (Member)_cboxBookingByMember_MemberName.SelectedItem;
                    ShowCreateBookingConfirmation(SelectedPilot.FullName);

                    _panelFooterBookingByMember_Create.Visible = false;
                    _panelFooterBookingByMemberCRUD.Visible = true;
                    _panelBookingByMBR_Details.Visible = false;

                    BookingForMemberCreated();
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

                BookingForMemberCreated();
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

            BookingForMemberUpdating();

            UnlockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByMember_UpdateConfirm_Click(object sender, EventArgs e)
        {
            bool hasError = DetectUnfilledFields();
            if (hasError)
            {
                MessageBoxHelper.ShowMandatoryDataError();
            }
            else
            {
                try
                {
                    Booking booking = GetUpdatingBooking();
                    BookingService.UpdateOne(booking);

                    _bookingBackup = null;

                    HideErrorMessage();
                    LockControls();

                    _panelFooterBookingByMember_Update.Visible = false;
                    _panelFooterBookingByMemberCRUD.Visible = true;
                    _panelBookingByMBR_Details.Visible = false;

                    BookingForMemberUpdated();

                    MessageBoxHelper.ShowBookingUpdateSuccess(SelectedBooking.MemberFullName);
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

                BookingForMemberUpdated();
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

            BookingForMemberCanceling();

            LockControls();

            _bookingBackup = SelectedBooking.CreateDeepCopy();
        }

        private void _btnFooterBookingByMember_CancelConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_tboxBookingByMBR_CancellationReason.Text))
            {
                MessageBox.Show(
                    "Le motif d'annulation est obligatoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DateTime today = DateTime.Now;
                bool isToday = SelectedBooking.Date.Year == today.Year
                    && SelectedBooking.Date.Month == today.Month
                    && SelectedBooking.Date.Day == today.Day + 1;

                if (isToday && SelectedBooking.StartHour < new TimeSpan(today.Hour + 18, today.Minute, 0))
                {
                    MessageBox.Show(
                        "Une annulation doit normalement se faire au minimum 18 heures à l'avance",
                        "Attention",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                DialogResult dialogResult = MessageBoxHelper.ShowBookingCancel();

                try
                {
                    if (dialogResult == DialogResult.OK)
                    {
                        CancellationService.CreateOneCancellation(SelectedBooking.ID.Value, _tboxBookingByMBR_CancellationReason.Text);

                        _bookingBackup = null;

                        HideErrorMessage();

                        _labelBookingByMBR_CancellationReason.Visible = false;

                        _panelBookingByMBR_Details.Visible = false;
                        _panelFooterBookingByMember_Cancel.Visible = false;
                        _panelFooterBookingByMemberCRUD.Visible = true;

                        _tboxBookingByMBR_CancellationReason.Visible = false;

                        BookingForMemberCanceled();
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

                BookingForMemberCanceled();
            }
        }

        private void _cboxBookingByMember_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }
    }
}
