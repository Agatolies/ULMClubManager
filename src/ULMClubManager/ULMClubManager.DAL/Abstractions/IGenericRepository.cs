using System.Collections.Generic;

namespace ULMClubManager.DAL.Abstractions
{

    public interface IGenericRepository<TDomain, TKey>
    {
        TDomain CreateOne(TDomain domainModel);
        int CreateMany(IEnumerable<TDomain> domainModels);
        void DeleteOne(TKey id);
        IEnumerable<TDomain> ReadAll();
        TDomain ReadOne(TKey id);
        TDomain ReadLast();
        void UpdateOne(TDomain loc);
    }
}
