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
    public class LocalityMapper : IDomainMapper<LocDBRow, Locality>
    {
        public Locality From(LocDBRow loc)
        {
            return new Locality(loc.LOC_ID, loc.LOC_CP, loc.LOC_NOM);
        }

        public List<Locality> From(IEnumerable<LocDBRow> models)
        {
            List<Locality> domainModels = new List<Locality>();
            foreach (LocDBRow model in models)
            {
                Locality domainModel = this.From(model);
                domainModels.Add(domainModel);
            }

            return domainModels;
        }

        public LocDBRow To(Locality loc)
        {
            LocDBRow result = new LocDBRow();

            if (loc.ID.HasValue)
                result.LOC_ID = loc.ID.Value;

            result.LOC_CP = loc.ZipCode;
            result.LOC_NOM = loc.Name;

            return result;
        }

        public List<LocDBRow> To(IEnumerable<Locality> domainModels)
        {
            List<LocDBRow> models = new List<LocDBRow>();
            foreach (Locality domainModel in domainModels)
            {
                LocDBRow model = this.To(domainModel);
                models.Add(model);
            }

            return models;
        }
    }
}
