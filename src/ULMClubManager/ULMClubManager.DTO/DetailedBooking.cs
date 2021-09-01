using System;

namespace ULMClubManager.DTO
{
    // Nécessaire pour faire fonctionner CloneHelper
    [Serializable]
    public class DetailedBooking
    {
        public DetailedBooking(Booking booking, Aircraft aircraft, Runway runway, Member pilot)
        {
            ID = booking.ID;
            Date = booking.Date;
            StartHour = booking.StartHour;
            EndHour = booking.EndHour;
            CancellationReason = booking.CancellationReason;
            CancellationDate = booking.CancellationDate;
            CancellationHour = booking.CancellationHour;

            AircraftID = booking.AircraftID;
            AircraftRegistration = aircraft.Registration;
            AircraftCategoryID = aircraft.CategoryID;

            RunwayID = booking.RunwayID;
            RunwayAvailability = runway.Availability;

            MemberID = booking.MemberID;
            MemberLastName = pilot.LastName;
            MemberFirstName = pilot.FirstName;
        }

        // Booking
        public int? ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        public string CancellationReason { get; }
        public DateTime? CancellationDate { get; }
        public TimeSpan? CancellationHour { get; }

        // Aircraft
        public int AircraftID { get; }
        public string AircraftRegistration { get; }
        public string AircraftType { get; }
        public int AircraftCategoryID { get; }

        // Runway
        public int RunwayID { get; }
        public bool RunwayAvailability { get; }

        // Pilot
        public int MemberID { get; }
        public string MemberLastName { get; }
        public string MemberFirstName { get; }
        public string MemberFullName => $"{MemberLastName.ToUpper()} {MemberFirstName}";
    }
}
