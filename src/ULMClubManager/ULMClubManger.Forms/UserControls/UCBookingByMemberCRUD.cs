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
    public partial class UCBookingByMemberCRUD : UserControl
    {
        private List<DetailedBooking> _bookings;
        private DetailedBooking _selectedBooking;
        private DetailedBooking _bookingBackup;

        public UCBookingByMemberCRUD()
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

        public int BookingID { get; private set; }
        public int MemberID { get; private set; }

        private void InitializeData()
        {
            List<Aircraft> aircrafts = AircraftService.ReadAll();

            _bsAircrafts.DataSource = aircrafts;
            _cboxBookingByMember_TimeSlotStart.DataSource = GetTimeSlotsStart();
            _cboxBookingByMember_TimeSlotEnd.DataSource = TimeSlot.GetTimeSlots();
            _cboxBookingByMember_Runway.DataSource = RunwayService.ReadAll();

            _cboxBookingByMember_Aircraft.DisplayMember = "Registration";
            _cboxBookingByMember_Aircraft.ValueMember = "ID";
            _cboxBookingByMember_Runway.DisplayMember = "ID";
            _cboxBookingByMember_Runway.ValueMember = "ID";

            _panelBookingByMember_Create.Visible = false;
            _panelBookingByMember_Update.Visible = false;

            _labelBookingByMember_NewBooking.Visible = false;
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
            TimeSpan startTimeSlot = (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedValue;

            List<TimeSpan> timeSlots = TimeSlot
                // On récupère la liste de TOUS les timeslots
                .GetTimeSlots()
                // ...ensuite on supprime les éléments jusqu'à l'heure de début
                .Where(timeSlot => timeSlot > startTimeSlot)
                // ...et on supprime tous ceux qui sont plus de 6h dans le futur (RG)
                .Where(timeSlot => timeSlot <= startTimeSlot.Add(TimeSpan.FromHours(6)))
                .ToList();

            _cboxBookingByMember_TimeSlotEnd.DataSource = timeSlots;
        }

        public void RefreshData(int memberID)
        {
            Bookings = BookingService.ReadAllBookingByPilotID(memberID);
        }

        private void RefreshDetailsForm()
        {
            _tboxBookingByMember_MemberName.Text = _selectedBooking.MemberFullName;
            _cboxBookingByMember_Aircraft.SelectedValue = _selectedBooking.AircraftID;
            _dtpBookingByMember_Date.Value = _selectedBooking.Date;
            _cboxBookingByMember_TimeSlotStart.SelectedItem = _selectedBooking.StartHour;
            _cboxBookingByMember_TimeSlotEnd.SelectedItem = _selectedBooking.EndHour;
            _cboxBookingByMember_Runway.SelectedValue = _selectedBooking.RunwayID;
        }

        private void ClearData()
        {
            _bsBookings.Clear();
            _bsAircrafts.Clear();
        }

        private void ClearControls()
        {
            //_tboxBookingByMember_MemberName.Text = "";
            _cboxBookingByMember_Aircraft.SelectedValue = -1;
            _dtpBookingByMember_Date.Value = DateTime.Now;
            _cboxBookingByMember_TimeSlotStart.DataSource = TimeSlot.GetTimeSlots();
            _cboxBookingByMember_Runway.SelectedValue = -1;
        }

        private void LockControls()
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

        private void ShowErrorMessage(Exception ex)
        {
            string decoded = Rules.MessageDecoder(ContextError.RES, ex.Message);

            _labelBookingByMember_Error.Text = decoded;
            _labelBookingByMember_Error.Visible = true;
        }

        private void ShowErrorMessage(BusinessException ex)
        {
            string decoded = Rules.MessageDecoder(ex);

            _labelBookingByMember_Error.Text = decoded;
            _labelBookingByMember_Error.Visible = true;
        }

        private void HideErrorMessage()
        {
            _labelBookingByMember_Error.Text = "";
            _labelBookingByMember_Error.Visible = false;
        }

        private void _btnBookingByMemberCreate_Click(object sender, EventArgs e)
        {
            _panel_CRUD_BookingByMember_btn.Visible = false;
            _panelBookingByMember_Create.Visible = true;

            _bookingBackup = _selectedBooking.CreateDeepCopy();

            _labelBookingByMember_Details.Visible = false;
            _labelBookingByMember_NewBooking.Visible = true;

            _dtpBookingByMember_Date.Value = DateTime.Now;

            UnlockControls();
            ClearControls();
        }

        private void _btnBookingByMember_CreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Booking booking = new Booking(
                    _dtpBookingByMember_Date.Value,
                    (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedItem,
                    (TimeSpan)_cboxBookingByMember_TimeSlotEnd.SelectedItem,
                    "",
                    null,
                    null,
                    _selectedBooking.MemberID,
                    ((Aircraft)_cboxBookingByMember_Aircraft.SelectedItem).ID.Value,
                    ((Runway)_cboxBookingByMember_Runway.SelectedItem).ID.Value);

                BookingService.CreateOne(booking);

                _bookingBackup = null;

                HideErrorMessage();
                LockControls();

                _panelBookingByMember_Create.Visible = false;
                _panel_CRUD_BookingByMember_btn.Visible = true;

                MessageBox.Show(
                    $"La réserervation pour {_selectedBooking.MemberFullName} a bien été créé.",
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

        private void _btnBookingByMember_CreateCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous annuler la création de cette réservation ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                _selectedBooking = _bookingBackup;
                _bookingBackup = null;

                LockControls();
                HideErrorMessage();

                _panelBookingByMember_Create.Visible = false;
                _panel_CRUD_BookingByMember_btn.Visible = true;
            }
        }

        private void _btnBookingByMemberUpdate_Click(object sender, EventArgs e)
        {
            _panel_CRUD_BookingByMember_btn.Visible = false;
            _panelBookingByMember_Update.Visible = true;

            UnlockControls();

            _bookingBackup = _selectedBooking.CreateDeepCopy();
        }

        private void _btnBookingByMembe_UpdateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                BookingService.UpdateOne(_selectedBooking);

                _bookingBackup = null;

                HideErrorMessage();
                LockControls();

                _panelBookingByMember_Update.Visible = false;
                _panel_CRUD_BookingByMember_btn.Visible = true;

                MessageBox.Show(
                    $"La réservation pour {_selectedBooking.MemberFullName} a bien été mise à jour.",
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

        private void _btnBookingByMembe_UpdateDelete_Click(object sender, EventArgs e)
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

                _panelBookingByMember_Update.Visible = false;
                _panel_CRUD_BookingByMember_btn.Visible = true;
            }
        }

        private void _btnBookingByMemberDelete_Click(object sender, EventArgs e)
        {
            LockControls();

            DialogResult dialogResult = MessageBox.Show(
                "Voulez-vous confirmer la suppression de cette réservation ?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            try
            {
                if (dialogResult == DialogResult.OK)
                {
                    BookingService.DeleteOneBooking(_selectedBooking.ID.Value);

                    MessageBox.Show(
                        $"La réservation a bien été supprimée.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }


                ClearControls();
                HideErrorMessage();
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

        private void _dgvBookingByMemberCRUD_SelectionChanged(object sender, EventArgs e)
        {
            if (_bsBookings.Current != null)
            {
                _selectedBooking = (DetailedBooking)_bsBookings.Current;

                RefreshDetailsForm();

                //this.BookingID = current.ID.Value;
                //this.MemberID = current.MemberID;
            }
            else
            {
                _tboxBookingByMember_MemberName.Text = "";
                ClearControls();
            }
        }

        private void _cboxBookingByMember_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }

    }
}
