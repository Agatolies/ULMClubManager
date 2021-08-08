using System.Collections.Generic;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class CancellationMapper : GenericMapper<AnnDBRow, Cancellation>
    {
        public override Cancellation From(AnnDBRow ann)
        {
            return new Cancellation(ann.ANN_ID, ann.ANN_MOTIF, ann.ANN_DTE, ann.ANN_HEU);
        }

        public override AnnDBRow To(Cancellation ann)
        {
            AnnDBRow result = new AnnDBRow();

            if (ann.ID.HasValue)
                result.ANN_ID = ann.ID.Value;

            result.ANN_MOTIF = ann.Reason;
            result.ANN_DTE = ann.Date;
            result.ANN_HEU = ann.Hour;

            return result;
        }
    }
}
