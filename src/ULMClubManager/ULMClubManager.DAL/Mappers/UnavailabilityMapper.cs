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
    public class UnavailabilityMapper : IDomainMapper<IndDBRow, Unavailability>
    {
        public Unavailability From(IndDBRow model)
        {
            throw new NotImplementedException();
        }

        public List<Unavailability> From(IEnumerable<IndDBRow> models)
        {
            throw new NotImplementedException();
        }

        public IndDBRow To(Unavailability domainModel)
        {
            throw new NotImplementedException();
        }

        public List<IndDBRow> To(IEnumerable<Unavailability> domainModels)
        {
            throw new NotImplementedException();
        }
    }
}
