using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class BookingMapper : GenericMapper<ResDBRow, Booking>
    {
        public override Booking From(ResDBRow res)
        {
            return new Booking(res.RES_ID, res.RES_DTE, res.RES_HEU_DEB, res.RES_HEU_FIN, res.MBR_ID);
        }

        public override ResDBRow To(Booking res)
        {
            ResDBRow result = new ResDBRow();

            if (res.ID.HasValue)
                result.RES_ID = res.ID.Value;

            result.RES_DTE = res.Date;
            result.RES_HEU_DEB = res.StartHour;
            result.RES_HEU_FIN = res.EndHour;
            result.MBR_ID = res.MbrID;

            return result;
        }
    }
}
