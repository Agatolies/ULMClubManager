using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManger.Forms.UserControls
{
    public interface IUCBooking
    {
        void ShowErrorMessage(BusinessException ex);
        void ShowErrorMessage(Exception ex);
        void HideErrorMessage();
        void RefreshTimeSlotsEnd();
        void RefreshDetailsForm();
        void ClearControls();
        void LockControls();
        void UnlockControls();
        Booking GetEditedBooking();
    }

    public  class UCBookingBase : UserControl
    {
        protected List<TimeSpan> _timeSlotsStart;
        protected List<TimeSpan> _timeSlotsEnd;
        protected List<Member> _allPilots;
        protected List<Runway> _allRunways;
        protected List<Aircraft> _allAircrafts;

        protected DetailedBooking _bookingBackup;
        protected DetailedBooking _selectedBooking;

        public UCBookingBase()
        {
        }

        public int SelectedPilotID { get; set; }

        public Member SelectedPilot => _allPilots
                .Where(pilot => pilot.ID == SelectedPilotID)
                .FirstOrDefault();

        protected List<TimeSpan> GetTimeSlotsStart()
        {
            List<TimeSpan> allTimeSlots = TimeSlot.GetTimeSlots();
            allTimeSlots.RemoveAt(allTimeSlots.Count - 1);

            return allTimeSlots;
        }

        protected void InitializeData()
        {
            _timeSlotsStart = GetTimeSlotsStart();
            _timeSlotsEnd = TimeSlot.GetTimeSlots();

            _allPilots = MemberService.ReadAllPilots();
            _allRunways = RunwayService.ReadAll();
            _allAircrafts = AircraftService.ReadAll();
        }

        protected List<TimeSpan> GetMaximumBookingHours(TimeSpan startTimeSlot)
        {
            List<TimeSpan> timeSlots = TimeSlot
                // On récupère la liste de TOUS les timeslots
                .GetTimeSlots()
                // ...ensuite on supprime les éléments jusqu'à l'heure de début
                .Where(timeSlot => timeSlot > startTimeSlot.Add(TimeSpan.FromMinutes(45)))
                // ...et on supprime tous ceux qui sont plus de 6h dans le futur (RG)
                .Where(timeSlot => timeSlot <= startTimeSlot.Add(TimeSpan.FromHours(6)))
                .ToList();
            return timeSlots;
        }

        protected void ShowCreateBookingConfirmation(string pilotName)
        {
            MessageBox.Show(
                $"La réserervation pour {pilotName} a bien été créé.",
                "Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        protected DialogResult ShowCancelBookingCreation()
        {
            return MessageBox.Show(
                "Voulez-vous annuler la création de cette réservation ?",
                "Attention",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
        }
    }
}
