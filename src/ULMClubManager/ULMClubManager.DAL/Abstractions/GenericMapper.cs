using System.Collections.Generic;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DAL.Mappers
{
    public abstract class GenericMapper<TDBRow, TDomain> where TDomain : class, IDomainModel
    {
        public abstract TDomain From(TDBRow model);
        public abstract TDBRow To(TDomain domainModel);

        public List<TDomain> From(IEnumerable<TDBRow> models)
        {
            List<TDomain> domainModels = new List<TDomain>();
            foreach (TDBRow model in models)
            {
                TDomain domainModel = this.From(model);
                domainModels.Add(domainModel);
            }

            return domainModels;
        }

        public List<TDBRow> To(IEnumerable<TDomain> domainModels)
        {
            List<TDBRow> models = new List<TDBRow>();
            foreach (TDomain domainModel in domainModels)
            {
                TDBRow model = this.To(domainModel);
                models.Add(model);
            }

            return models;
        }
    }
}
