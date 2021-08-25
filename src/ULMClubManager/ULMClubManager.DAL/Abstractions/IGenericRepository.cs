using System.Collections.Generic;

namespace ULMClubManager.DAL.Abstractions
{

    public interface IGenericRepository<TDomain, TKey>
    {
        TDomain CreateOne(TDomain domainModel);
        int DeleteOne(TKey id);
        List<TDomain> ReadAll();
        TDomain ReadOne(TKey id);
        TDomain ReadLast();
        void UpdateOne(TDomain loc);
    }
}
