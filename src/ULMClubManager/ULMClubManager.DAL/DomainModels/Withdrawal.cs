using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
    public class Withdrawal : IDomainModel
    {
        public Withdrawal(int? id, DateTime startDate, DateTime endDate, string Reason, int mbrID)
        {

        }

        public Withdrawal(DateTime startDate, DateTime endDate, string Reason, int mbrID)
            : this(null, startDate, endDate, Reason, mbrID)
        {
        }

        public int? ID { get; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public int MbrID { get; set; }

        public override string ToString()
        {
            return $"retrait de la licence du membre {MbrID} du {StartDate} au {EndDate}";
        }

    }
}
