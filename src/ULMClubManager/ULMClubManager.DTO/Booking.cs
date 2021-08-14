﻿using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Booking : IDomainModel
    {
        public Booking( 
            int? id, DateTime date, TimeSpan startHour,
            TimeSpan endHour, int memberID, int aircraftID, int runwayID)
        {
            ID = id;
            Date = date;
            StartHour = startHour;
            EndHour = endHour;
            MemberID = memberID;
            AircraftID = aircraftID;
            RunwayID = runwayID;
        }

        public Booking(
            DateTime date, TimeSpan startHour, TimeSpan endHour, 
            int memberID, int aircraftID, int runwayID)
            : this(null, date, startHour, endHour, memberID, aircraftID, runwayID)
        {
        }

        public int? ID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        public int MemberID { get; set; }
        public int AircraftID { get; set; }
        public int RunwayID { get; set; }

        public override string ToString()
        {
            return $"La réservation de {MemberID} du {Date} de {StartHour} jusqu'à {EndHour}";
        }
    }
}
