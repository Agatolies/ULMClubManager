using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class RunwayMapper : GenericMapper<PistDBRow, Runway>
    {
        public override Runway From(PistDBRow pist)
        {
            return new Runway(pist.PIST_ID, pist.PIST_DISPO);
        }

        public override PistDBRow To(Runway pist)
        {
            PistDBRow result = new PistDBRow();

            if (pist.ID.HasValue)
                result.PIST_ID = pist.ID.Value;

            result.PIST_DISPO = pist.Availability;

            return result;
        }
    }
}
