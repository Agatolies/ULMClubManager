using System.Collections.Generic;

namespace ULMClubManager.DAL.Abstractions
{

    public interface IGenericRepository<TModel, TKey>
    {
        void CreateOne(TModel model);
        int CreateMany(IEnumerable<TModel> models);
        void DeleteOne(TKey id);
        IEnumerable<TModel> ReadAll();
        TModel ReadOne(TKey id);
        void UpdateOne(TModel loc);
    }
}
