using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Cancellation : IDomainModel
    {
        public Cancellation(
            int? bookingID, string reason, string aircraftRegistration, 
            int runwayID, DateTime? bookingDate, TimeSpan? startHour, 
            TimeSpan? endHour)
        {
            ID = bookingID;
            Reason = reason;
            AircraftRegistration = aircraftRegistration;
            RunwayID = runwayID;
            BookingDate = bookingDate;
            StartHour = startHour;
            EndHour = endHour;
            
        }

        public Cancellation(int? bookingID, string reason)
            : this(bookingID, reason, "", 1, null, null, null)
        {

        }

        // Cancellation
        public int? ID { get; set; }
        public string Reason { get; }

        // Aircraft

        public string AircraftRegistration { get; }

        // Runway
        public int RunwayID { get; }

        // Registration
        public DateTime? BookingDate { get; }
        public TimeSpan? StartHour { get; }
        public TimeSpan? EndHour { get; }


    }
}
