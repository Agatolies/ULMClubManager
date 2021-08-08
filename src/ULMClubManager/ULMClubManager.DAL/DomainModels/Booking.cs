using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
    public class Booking : IDomainModel
    {
        public Booking(int? id, DateTime date, string startHour, string endHour, int mbrID)
        {

        }

        public Booking(DateTime date, string startHour, string endHour, int mbrID)
            : this(null, date, startHour, endHour, mbrID)
        {
        }

        public int? ID { get; set; }
        public DateTime Date { get; set; }
        public string StartHour { get; set; }
        public string EndHour { get; set; }
        public int MbrID { get; set; }

        public override string ToString()
        {
            return $"La réservation de {MbrID} du {Date} de {StartHour} jusqu'à {EndHour}";
        }
    }
}
