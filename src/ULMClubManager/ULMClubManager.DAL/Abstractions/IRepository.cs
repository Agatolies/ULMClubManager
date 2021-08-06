using System.Collections.Generic;

namespace ULMClubManager.DAL.Abstractions
{
    public interface IRepository<TModel, TKey>
    {
        void CreateOne(TModel loc);
        void DeleteOne(TKey id);
        IEnumerable<TModel> ReadAll();
        TModel ReadOne(TKey id);
        void UpdateOne(TModel loc);
    }
}
