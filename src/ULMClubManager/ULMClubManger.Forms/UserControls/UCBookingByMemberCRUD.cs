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

namespace ULMClubManger.Forms.UserControls
{
    public partial class UCBookingByMemberCRUD : UserControl
    {
        private List<DetailedBooking> _bookings;
        private DetailedBooking _selectedBooking;

        public UCBookingByMemberCRUD()
        {
            InitializeComponent();
            InitializeData();

            _cboxBookingByMember_Aircraft.DisplayMember = "Registration";
            _cboxBookingByMember_Aircraft.ValueMember = "ID";
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

            _panelBookingByMember_Create.Visible = false;
            _panelBookingByMember_Update.Visible = false;
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
        }

        private void LockControls()
        {
            _cboxBookingByMember_Aircraft.Enabled = false;
            _dtpBookingByMember_Date.Enabled = false;
            _cboxBookingByMember_TimeSlotStart.Enabled = false;
            _cboxBookingByMember_TimeSlotEnd.Enabled = false;
        }

        public void UnlockControls()
        {
            _cboxBookingByMember_Aircraft.Enabled = true;
            _dtpBookingByMember_Date.Enabled = true;
            _cboxBookingByMember_TimeSlotStart.Enabled = true;
            _cboxBookingByMember_TimeSlotEnd.Enabled = true;
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

            _dtpBookingByMember_Date.Value = DateTime.Now;

            UnlockControls();
            ClearControls();
        }

        private void _btnBookingByMember_CreateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //TimeSpan.

                Booking booking = new Booking(
                    _dtpBookingByMember_Date.Value,
                    (TimeSpan)_cboxBookingByMember_TimeSlotStart.SelectedItem,
                    (TimeSpan)_cboxBookingByMember_TimeSlotEnd.SelectedItem,
                    "",
                    null,
                    null,
                    MemberID,
                    ((Aircraft)_cboxBookingByMember_Aircraft.SelectedItem).ID.Value,
                    ((Runway)_cboxBookingByMember_Runway.SelectedItem).ID.Value);

                BookingService.CreateOne(booking);
            }
            catch (BusinessException ex)
            {

            }
        }

        private void _btnBookingByMemberUpdate_Click(object sender, EventArgs e)
        {
            _panel_CRUD_BookingByMember_btn.Visible = false;
            _panelBookingByMember_Update.Visible = true;

            UnlockControls();


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

                    HideErrorMessage();
                    RefreshData(this.MemberID);

                    //if (BookingService.DeleteOneBooking(_selectedBooking.ID.Value) == 1)
                    //{
                    //}
                    //else
                    //{
                    //    MessageBox.Show(
                    //        "Réservation non trouvée.",
                    //        "Avertissement",
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Warning);
                    //}
                }
                else
                {
                    RefreshData(this.MemberID);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Réservation non trouvée.",
                    "Avertissement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void _dgvBookingByMemberCRUD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _dgvBookingByMemberCRUD.AllowUserToAddRows = true;
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
        }

        private void _cboxBookingByMember_TimeSlotStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTimeSlotsEnd();
        }
    }
}
