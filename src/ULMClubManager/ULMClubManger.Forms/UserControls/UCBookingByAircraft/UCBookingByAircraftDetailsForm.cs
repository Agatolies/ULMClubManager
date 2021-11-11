using ULMClubManager.BL;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Enums;
using ULMClubManager.DTO.Exceptions;
using ULMClubManager.DTO.Helpers;

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByAircraftDetailsForm : UCBookingBase, IUCBooking
    {
        public event delBookingForAircraftCreated? BookingForAircraftCreating;
        public event delBookingForAircraftUpdated? BookingForAircraftUpdating;
        public event delBookingForAircraftCanceled? BookingForAircraftCanceling;

        public event delBookingForAircraftCreated? BookingForAircraftCreated;
        public event delBookingForAircraftUpdated? BookingForAircraftUpdated;
        public event delBookingForAircraftCanceled? BookingForAircraftCanceled;

        public UCBookingByAircraftDetailsForm()
        {
            InitializeComponent();
            InitializeData();
        }

        public DetailedBooking? SelectedBooking
        {
            get { return _selectedBooking; }
            set
            {
                if (value != null)
                {
                    _selectedBooking = value;

                    _btnFooterBookingByAircraftUpdate.Visible = true;
                    _btnFooterBookingByAircraftCancel.Visible = true;

                    RefreshDetailsForm();
                }
                else
                {
                    _cboxBookingByAircraft_MemberName.SelectedIndex = -1;

                    _btnFooterBookingByAircraftUpdate.Visible = false;
                    _btnFooterBookingByAircraftCancel.Visible = false;

                    ClearControls();
                }
            }
        }

        private new void InitializeData()
        {
            base.InitializeData();

            _cboxBookingByAircraft_TimeSlotStart.DataSource = _timeSlotsStart;
            _cboxBookingByAircraft_TimeSlotEnd.DataSource = _timeSlotsEnd;

            _cboxBookingByAircraft_Aircraft.DisplayMember = "Registration";
            _cboxBookingByAircraft_Aircraft.ValueMember = "ID";
            _cboxBookingByAircraft_Runway.DisplayMember = "ID";
            _cboxBookingByAircraft_Runway.ValueMember = "ID";
            _cboxBookingByAircraft_MemberName.DisplayMember = "FullName";
            _cboxBookingByAircraft_MemberName.ValueMember = "ID";

            _bsAircrafts.DataSource = _allAircrafts;
            _bsPilots.DataSource = _allPilots;
            _bsRunways.DataSource = _allRunways;

            _panelBookingByAircraft_Details.Visible = false;
        }

        public void ShowErrorMessage(BusinessException ex)
        {
            _labelBookingByAircraft_ErrorMessage.Text = Rules.MessageDecoder(ex);
            _labelBookingByAircraft_ErrorMessage.Visible = true;
        }

        public void ShowErrorMessage(Exception ex)
        {
            _labelBookingByAircraft_ErrorMessage.Text = Rules.MessageDecoder(ContextError.RES, ex.Message);
            _labelBookingByAircraft_ErrorMessage.Visible = true;
        }

        public void HideErrorMessage()
        {
            _labelBookingByAircraft_ErrorMessage.Text = "";
            _labelBookingByAircraft_ErrorMessage.Visible = false;
        }

        public void RefreshTimeSlotsEnd()
        {
            // On récupère l'heure de début
            TimeSpan startTimeSlot = (TimeSpan)_cboxBookingByAircraft_TimeSlotStart.SelectedValue;
            _cboxBookingByAircraft_TimeSlotEnd.DataSource = GetMaximumBookingHours(startTimeSlot);
        }

        public void RefreshDetailsForm()
        {
            _cboxBookingByAircraft_MemberName.SelectedValue = SelectedBooking.MemberID;
            _cboxBookingByAircraft_Aircraft.SelectedValue = SelectedBooking.AircraftID;
            _dtpBookingByAircraft_Date.Value = SelectedBooking.Date;
            _cboxBookingByAircraft_TimeSlotStart.SelectedItem = SelectedBooking.StartHour;
            _cboxBookingByAircraft_TimeSlotEnd.SelectedItem = SelectedBooking.EndHour;
            _cboxBookingByAircraft_Runway.SelectedValue = SelectedBooking.RunwayID;
        }

        public void ClearControls()
        {
            _cboxBookingByAircraft_Aircraft.SelectedValue = -1;
            _dtpBookingByAircraft_Date.Value = DateTime.Now;
            _cboxBookingByAircraft_TimeSlotStart.DataSource = TimeSlot.GetTimeSlots();
            _cboxBookingByAircraft_Runway.SelectedValue = -1;
            _cboxBookingByAircraft_MemberName.SelectedValue = -1;
            _tboxBookingByAircraft_CancellationReason.Text = "";
        }

        public void LockControls()
        {
            _cboxBookingByAircraft_Aircraft.Enabled = false;
            _dtpBookingByAircraft_Date.Enabled = false;
            _cboxBookingByAircraft_TimeSlotStart.Enabled = false;
            _cboxBookingByAircraft_TimeSlotEnd.Enabled = false;
            _cboxBookingByAircraft_Runway.Enabled = false;
        }

        public void UnlockControls()
        {
            _cboxBookingByAircraft_Aircraft.Enabled = true;
            _dtpBookingByAircraft_Date.Enabled = true;
            _cboxBookingByAircraft_TimeSlotStart.Enabled = true;
            _cboxBookingByAircraft_TimeSlotEnd.Enabled = true;
            _cboxBookingByAircraft_Runway.Enabled = true;
        }

        public Booking GetCreatingBooking()
        {
            return new Booking(
                _dtpBookingByAircraft_Date.Value,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotEnd.SelectedItem,
                null,
                null,
                null,
                ((Member)_cboxBookingByAircraft_MemberName.SelectedItem).ID.Value,
                ((Aircraft)_cboxBookingByAircraft_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByAircraft_Runway.SelectedItem).ID.Value);
        }

        public Booking GetUpdatingBooking()
        {
            return new Booking(
                SelectedBooking.ID,
                _dtpBookingByAircraft_Date.Value,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotEnd.SelectedItem,
                null,
                null,
                null,
                ((Member)_cboxBookingByAircraft_MemberName.SelectedItem).ID.Value,
                ((Aircraft)_cboxBookingByAircraft_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByAircraft_Runway.SelectedItem).ID.Value);
        }

        private bool DetectUnfilledFields()
        {
            bool isMemberNameNotFilled = _cboxBookingByAircraft_MemberName.SelectedIndex == -1;
            bool isAircraftNotFilled = _cboxBookingByAircraft_Aircraft.SelectedIndex == -1;
            bool isRunwayNotFilled = _cboxBookingByAircraft_Runway.SelectedIndex == -1;
            return isMemberNameNotFilled || isAircraftNotFilled || isRunwayNotFilled;
        }

        // Ajout d'une réservation

        private void _btnFooterBookingByAircraftCreate_Click(object sender, EventArgs e)
        {
            _labelBookingByAircraft_DetailsTitle.Text = "NOUVELLE RESERVATION";

            _cboxBookingByAircraft_MemberName.Enabled = true;

            _panelFooterBookingByAircraftCRUD.Visible = false;
            _panelFooterBookingByAircraft_Create.Visible = true;
            _panelBookingByAircraft_Details.Visible = true;

            _bookingBackup = SelectedBooking?.CreateDeepCopy();

            _dtpBookingByAircraft_Date.Value = DateTime.Now;

            BookingForAircraftCreating();

            UnlockControls();
            ClearControls();
        }

        private void _btnFooterBookingByAircraft_CreateConfirm_Click(object sender, EventArgs e)
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

                    Member member = (Member)_cboxBookingByAircraft_MemberName.SelectedItem;
                    ShowCreateBookingConfirmation(member.FullName);

                    _panelFooterBookingByAircraft_Create.Visible = false;
                    _panelFooterBookingByAircraftCRUD.Visible = true;
                    _panelBookingByAircraft_Details.Visible = false;

                    BookingForAircraftCreated();
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

        private void _btnFooterBookingByAircraft_CreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = ShowCancelBookingCreation();

            if (dialogResult == DialogResult.Yes)
            {
                SelectedBooking = _bookingBackup;
                _bookingBackup = null;

                LockControls();
                HideErrorMessage();

                _panelFooterBookingByAircraft_Create.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;
                _panelBookingByAircraft_Details.Visible = false;

                BookingForAircraftCreated();
            }
        }

        // Modification d'une réservation

        private void _btnFooterBookingByAircraftUpdate_Click(object sender, EventArgs e)
        {
            _labelBookingByAircraft_DetailsTitle.Text = "MODIFICATION DE LA RESERVATION";

            _panelFooterBookingByAircraftCRUD.Visible = false;
            _panelFooterBookingByAircraft_Update.Visible = true;
            _panelBookingByAircraft_Details.Visible = true;

            BookingForAircraftUpdating();

            UnlockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByAircraft_UpdateConfirm_Click(object sender, EventArgs e)
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

                    _panelFooterBookingByAircraft_Update.Visible = false;
                    _panelFooterBookingByAircraftCRUD.Visible = true;
                    _panelBookingByAircraft_Details.Visible = false;

                    BookingForAircraftUpdated();

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

        private void _btnFooterBookingByAircraft_UpdateDelete_Click(object sender, EventArgs e)
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

                _panelFooterBookingByAircraft_Update.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;
                _panelBookingByAircraft_Details.Visible = false;

                BookingForAircraftUpdated();
            }
        }

        // Annulation d'une réservation

        private void _btnFooterBookingByAircraftCancel_Click(object sender, EventArgs e)
        {
            _labelBookingByAircraft_CancellationReason.Visible = true;
            _labelBookingByAircraft_DetailsTitle.Text = "ANNULATION DE LA RESERVATION";

            _panelBookingByAircraft_Details.Visible = true;
            _panelFooterBookingByAircraft_Cancel.Visible = true;
            _panelFooterBookingByAircraftCRUD.Visible = false;

            _tboxBookingByAircraft_CancellationReason.Visible = true;

            BookingForAircraftCanceling();

            LockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByAircraft_CancelConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_tboxBookingByAircraft_CancellationReason.Text))
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
                        CancellationService.CreateOneCancellation(SelectedBooking.ID.Value, _tboxBookingByAircraft_CancellationReason.Text);

                        _bookingBackup = null;

                        HideErrorMessage();

                        _panelBookingByAircraft_Details.Visible = false;
                        _panelFooterBookingByAircraft_Cancel.Visible = false;
                        _panelFooterBookingByAircraftCRUD.Visible = true;

                        _tboxBookingByAircraft_CancellationReason.Visible = false;

                        BookingForAircraftCanceled();
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

        private void _btnFooterBookingByAircraft_CancelCancel_Click(object sender, EventArgs e)
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

                _panelBookingByAircraft_Details.Visible = false;
                _panelFooterBookingByAircraft_Cancel.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;

                _tboxBookingByAircraft_CancellationReason.Visible = false;

                BookingForAircraftCanceled();
            }
        }

        private void _cboxBookingByAircraft_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }
    }
}
