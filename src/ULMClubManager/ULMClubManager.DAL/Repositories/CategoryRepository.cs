using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<TypDBRow, int, Category>
    {
        public CategoryRepository(string connectionString, CategoryMapper mapper)
            : base(connectionString, "TYP", mapper)
        {
        }
    }
}
