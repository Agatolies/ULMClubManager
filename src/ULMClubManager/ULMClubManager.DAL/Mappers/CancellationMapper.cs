using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class CancellationMapper : GenericMapper<AnnDBRow, Cancellation>
    {
        public override Cancellation From(AnnDBRow ann)
        {
            return new Cancellation(
                ann.RES_FK_ID, ann.ANN_MOTIF);
        }

        public override AnnDBRow To(Cancellation ann)
        {
            AnnDBRow result = new AnnDBRow();

            if (ann.ID.HasValue)
                result.RES_FK_ID = ann.ID.Value;

            result.ANN_MOTIF = ann.Reason;

            return result;
        }


    }
}
