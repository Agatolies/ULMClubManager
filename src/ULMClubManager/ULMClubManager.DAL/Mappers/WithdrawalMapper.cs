using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class WithdrawalMapper : GenericMapper<RetDBRow, Withdrawal>
    {
        public override Withdrawal From(RetDBRow ret)
        {
            return new Withdrawal(ret.RET_ID, ret.RET_DTE_DEB, ret.RET_DTE_FIN, ret.RET_MOTIF, ret.MBR_FK_ID);
        }

        public override RetDBRow To(Withdrawal ret)
        {
            RetDBRow result = new RetDBRow();

            if (ret.ID.HasValue)
                result.RET_ID = ret.ID.Value;

            result.RET_DTE_DEB = ret.StartDate;
            result.RET_DTE_FIN = ret.EndDate;
            result.RET_MOTIF = ret.Reason;
            result.MBR_FK_ID = ret.MemberID;

            return result;
        }
    }
}
