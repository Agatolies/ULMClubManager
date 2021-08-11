using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Unavailability : IDomainModel
    {
        public Unavailability(
            int? id, DateTime startDate, string startHour, 
            DateTime endDate, string endHour, string description, int aircraftID)
        {
            ID = id;
            StartDate = startDate;
            StartHour = startHour;
            EndDate = endDate;
            EndHour = endHour;
            Description = description;
            AircraftID = aircraftID;
        }

        public int? ID { get; }
        public DateTime StartDate { get; set; }
        public string StartHour { get; set; }
        public DateTime EndDate { get; set; }
        public string EndHour { get; set; }
        public string Description { get; set; }
        public int AircraftID { get; set; }

        public override string ToString()
        {
            return $"Du {StartDate:d} {StartHour} au {EndDate:d} {EndHour} pour l'aéronef {AircraftID}";
        }
    }
}
