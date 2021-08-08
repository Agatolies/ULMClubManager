using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class PilotMapper : GenericMapper<PilDBRow, Pilot>
    {
        public override Pilot From(PilDBRow pil)
        {
            return new Pilot(pil.MBR_ID, pil.PIL_NUM_LIC, pil.PIL_LIC_DTE_OBT, pil.PIL_LIC_DTE_EXP, pil.PIL_LIC_PAYS);
        }

        public override PilDBRow To(Pilot pil)
        {
            PilDBRow result = new PilDBRow();

            if (pil.ID.HasValue)
                result.MBR_ID = pil.ID.Value;

            result.PIL_NUM_LIC = pil.LicenceNumber;
            result.PIL_LIC_DTE_OBT = pil.ObtentionDate;
            result.PIL_LIC_DTE_EXP = pil.ExpirationDate;
            result.PIL_LIC_PAYS = pil.Country;

            return result;
        }
    }
}
