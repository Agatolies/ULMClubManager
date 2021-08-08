using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class SupporterMapper : GenericMapper<SymDBRow, Supporter>
    {
        public override Supporter From(SymDBRow sym)
        {
            return new Supporter(sym.MRB_ID);
        }

        public override SymDBRow To(Supporter sym)
        {
            SymDBRow result = new SymDBRow();

            if (sym.ID.HasValue)
                result.MRB_ID = sym.ID.Value;

            return result;
        }
    }
}
