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
    public class SubscriptionMapper : GenericMapper<CotiDBRow, Subscription>
    {
        public override Subscription From(CotiDBRow coti)
        {
            return new Subscription(coti.COTI_ID, coti.COTI_DTE_EMI, coti.COTI_DTE_PAI, coti.COTI_MONT, coti.MBR_ID);
        }

        public override CotiDBRow To(Subscription coti)
        {
            CotiDBRow result = new CotiDBRow();

            if (coti.ID.HasValue)
                result.COTI_ID = coti.ID.Value;

            result.COTI_DTE_EMI = coti.IssueDate;
            result.COTI_DTE_PAI = coti.PaymentDate;
            result.COTI_MONT = coti.Fee;
            result.MBR_ID = coti.MemberID;

            return result;
        }
    }
}
