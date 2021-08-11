using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class LocalityRepository : GenericRepository<LocDBRow, int, Locality>
    {
        public LocalityRepository(IUnitOfWork unitOfWork, LocalityMapper mapper)
            : base(unitOfWork, "LOC", mapper)
        {
        }
    }
}
