using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DAL.Abstractions
{
    public interface IDomainMapper<TDBRow, TDomain> where TDomain : class
    {
        TDomain From(TDBRow model);
        List<TDomain> From(IEnumerable<TDBRow> models);
        TDBRow To(TDomain domainModel);
        List<TDBRow> To(IEnumerable<TDomain> domainModels);
    }
}
