using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class UCBookingByAircraftDetailsForm : UserControl
    {
        public event delBookingForAircraftCreated BookingForAircraftCreating;
        public event delBookingForAircraftUpdated BookingForAircraftUpdating;
        public event delBookingForAircraftCanceled BookingForAircraftCanceling;

        public event delBookingForAircraftCreated BookingForAircraftCreated;
        public event delBookingForAircraftUpdated BookingForAircraftUpdated;
        public event delBookingForAircraftCanceled BookingForAircraftCanceled;

        private DetailedBooking _bookingBackup;
        private DetailedBooking _selectedBooking;

        public UCBookingByAircraftDetailsForm()
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
                    RefreshDetailsForm();
                }
                else
                {
                    _cboxBookingByAircraft_MemberName.SelectedIndex = -1;
                    ClearControls();
                }
            }
        }

        private void InitializeData()
        {
            _cboxBookingByAircraft_TimeSlotStart.DataSource = GetTimeSlotsStart();
            _cboxBookingByAircraft_TimeSlotEnd.DataSource = TimeSlot.GetTimeSlots();

            _cboxBookingByAircraft_Aircraft.DisplayMember = "Registration";
            _cboxBookingByAircraft_Aircraft.ValueMember = "ID";
            _cboxBookingByAircraft_Runway.DisplayMember = "ID";
            _cboxBookingByAircraft_Runway.ValueMember = "ID";
            _cboxBookingByAircraft_MemberName.DisplayMember = "FullName";
            _cboxBookingByAircraft_MemberName.ValueMember = "ID";

            _bsAircrafts.DataSource = AircraftService.ReadAll(); 
            _bsPilots.DataSource = MemberService.ReadAllPilots();
            _bsRunways.DataSource = RunwayService.ReadAll();

            _panelBookingByAircraft_Details.Visible = false;
        }

        private void ClearData()
        {
            _bsAircrafts.Clear();
        }

        private void ShowErrorMessage(BusinessException ex)
        {
            string decoded = Rules.MessageDecoder(ex);

            _labelBookingByAircraft_ErrorMessage.Text = decoded;
            _labelBookingByAircraft_ErrorMessage.Visible = true;
        }

        private void ShowErrorMessage(Exception ex)
        {
            string decoded = Rules.MessageDecoder(ContextError.RES, ex.Message);

            _labelBookingByAircraft_ErrorMessage.Text = decoded;
            _labelBookingByAircraft_ErrorMessage.Visible = true;
        }

        private void HideErrorMessage()
        {
            _labelBookingByAircraft_ErrorMessage.Text = "";
            _labelBookingByAircraft_ErrorMessage.Visible = false;
        }

        private List<TimeSpan> GetTimeSlotsStart()
        {
            List<TimeSpan> allTimeSlots = TimeSlot.GetTimeSlots();
            allTimeSlots.RemoveAt(allTimeSlots.Count - 1);

            return allTimeSlots;
        }

        private void RefreshTimeSlotsEnd()
        {
            // On récupère l'heure de début
            TimeSpan startTimeSlot = (TimeSpan)_cboxBookingByAircraft_TimeSlotStart.SelectedValue;

            List<TimeSpan> timeSlots = TimeSlot
                // On récupère la liste de TOUS les timeslots
                .GetTimeSlots()
                // ...ensuite on supprime les éléments jusqu'à l'heure de début
                .Where(timeSlot => timeSlot > startTimeSlot)
                // ...et on supprime tous ceux qui sont plus de 6h dans le futur (RG)
                .Where(timeSlot => timeSlot <= startTimeSlot.Add(TimeSpan.FromHours(6)))
                .ToList();

            _cboxBookingByAircraft_TimeSlotEnd.DataSource = timeSlots;
        }

        private void RefreshDetailsForm()
        {
            _cboxBookingByAircraft_MemberName.SelectedValue = SelectedBooking.MemberID;
            _cboxBookingByAircraft_Aircraft.SelectedValue = SelectedBooking.AircraftID;
            _dtpBookingByAircraft_Date.Value = SelectedBooking.Date;
            _cboxBookingByAircraft_TimeSlotStart.SelectedItem = SelectedBooking.StartHour;
            _cboxBookingByAircraft_TimeSlotEnd.SelectedItem = SelectedBooking.EndHour;
            _cboxBookingByAircraft_Runway.SelectedValue = SelectedBooking.RunwayID;
        }

        private void ClearControls()
        {
            _cboxBookingByAircraft_Aircraft.SelectedValue = -1;
            _dtpBookingByAircraft_Date.Value = DateTime.Now;
            _cboxBookingByAircraft_TimeSlotStart.DataSource = TimeSlot.GetTimeSlots();
            _cboxBookingByAircraft_Runway.SelectedValue = -1;
            _cboxBookingByAircraft_MemberName.SelectedValue = -1;
        }

        private void LockControls()
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

        private Booking GetEditedBooking()
        {
            return new Booking(
                _dtpBookingByAircraft_Date.Value,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotStart.SelectedItem,
                (TimeSpan)_cboxBookingByAircraft_TimeSlotEnd.SelectedItem,
                "",
                null,
                null,
                ((Member)_cboxBookingByAircraft_MemberName.SelectedItem).ID.Value,
                ((Aircraft)_cboxBookingByAircraft_Aircraft.SelectedItem).ID.Value,
                ((Runway)_cboxBookingByAircraft_Runway.SelectedItem).ID.Value);
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

            this.BookingForAircraftCreating();

            UnlockControls();
            ClearControls();
        }

        private void _btnFooterBookingByAircraft_CreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking = GetEditedBooking();

                BookingService.CreateOne(booking);

                _bookingBackup = null;

                //RefreshData(_selectedBooking.MemberID);
                HideErrorMessage();
                LockControls();

                _panelFooterBookingByAircraft_Create.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;
                _panelBookingByAircraft_Details.Visible = false;

                this.BookingForAircraftCreated();

                MessageBox.Show(
                    $"La réserervation pour {SelectedBooking.MemberFullName} a bien été créé.",
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

        private void _btnFooterBookingByAircraft_CreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler la création de cette réservation ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                SelectedBooking = _bookingBackup;
                _bookingBackup = null;

                LockControls();
                HideErrorMessage();

                _panelFooterBookingByAircraft_Create.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;
                _panelBookingByAircraft_Details.Visible = false;

                this.BookingForAircraftCreated();
            }
        }

        // Modification d'une réservation

        private void _btnFooterBookingByAircraftUpdate_Click(object sender, EventArgs e)
        {
            _labelBookingByAircraft_DetailsTitle.Text = "MODIFICATION DE LA RESERVATION";

            _panelFooterBookingByAircraftCRUD.Visible = false;
            _panelFooterBookingByAircraft_Update.Visible = true;
            _panelBookingByAircraft_Details.Visible = true;

            this.BookingForAircraftUpdating();

            UnlockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByAircraft_UpdateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking = GetEditedBooking();

                BookingService.UpdateOne(booking);

                _bookingBackup = null;

                HideErrorMessage();
                LockControls();
                //RefreshData(_selectedBooking.MemberID);

                _panelFooterBookingByAircraft_Update.Visible = false;
                _panelFooterBookingByAircraftCRUD.Visible = true;
                _panelBookingByAircraft_Details.Visible = false;

                this.BookingForAircraftUpdating();

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

                this.BookingForAircraftUpdated();
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

            this.BookingForAircraftCanceling();

            LockControls();

            _bookingBackup = SelectedBooking?.CreateDeepCopy();
        }

        private void _btnFooterBookingByAircraft_CancelConfirm_Click(object sender, EventArgs e)
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
                    CancellationService.CreateOneCancellation(SelectedBooking.ID.Value, _tboxBookingByAircraft_CancellationReason.Text);

                    _bookingBackup = null;

                    //RefreshData(_selectedBooking.MemberID);
                    HideErrorMessage();

                    _panelBookingByAircraft_Details.Visible = false;
                    _panelFooterBookingByAircraft_Cancel.Visible = false;
                    _panelFooterBookingByAircraftCRUD.Visible = true;

                    _tboxBookingByAircraft_CancellationReason.Visible = false;

                    this.BookingForAircraftCanceled();
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

        private void _btnFooterBookingByAircraft_CancelCancel_Click(object sender, EventArgs e)
        {
            SelectedBooking = _bookingBackup;
            _bookingBackup = null;

            LockControls();
            HideErrorMessage();

            _panelBookingByAircraft_Details.Visible = false;
            _panelFooterBookingByAircraft_Cancel.Visible = false;
            _panelFooterBookingByAircraftCRUD.Visible = true;

            _tboxBookingByAircraft_CancellationReason.Visible = false;

            this.BookingForAircraftCanceled();
        }

        private void _cboxBookingByAircraft_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }
    }
}
