using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class CategoryRepository : GenericRepository<TypDBRow, int, Category>
    {
        public CategoryRepository(IUnitOfWork unitOfWork, CategoryMapper mapper)
            : base(unitOfWork, "TYP", mapper)
        {
        }
    }
}
