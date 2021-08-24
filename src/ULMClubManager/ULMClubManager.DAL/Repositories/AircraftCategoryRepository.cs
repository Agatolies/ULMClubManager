using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class AircraftCategoryRepository : GenericRepository<TypDBRow, int, AircraftCategory>
    {
        public AircraftCategoryRepository(IUnitOfWork unitOfWork, CategoryMapper mapper)
            : base(unitOfWork, "TYP", mapper)
        {
        }
    }
}
