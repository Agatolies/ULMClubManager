using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class UnavailabilityMapper : GenericMapper<IndDBRow, Unavailability>
    {
        public override Unavailability From(IndDBRow ind)
        {
            return new Unavailability(ind.IND_ID, ind.IND_DTE_DEB, ind.IND_HEU_DEB, ind.IND_DTE_FIN, ind.IND_HEU_FIN, ind.IND_DES, ind.AER_ID);
        }

        public override IndDBRow To(Unavailability ind)
        {
            IndDBRow result = new IndDBRow();

            if (ind.ID.HasValue)
                result.IND_ID = ind.ID.Value;

            result.IND_DTE_DEB = ind.StartDate;
            result.IND_HEU_DEB = ind.StartHour;
            result.IND_DTE_FIN = ind.EndDate;
            result.IND_HEU_FIN = ind.EndHour;
            result.IND_DES = ind.Description;
            result.AER_ID = ind.AircraftID;

            return result;
        }
    }
}
