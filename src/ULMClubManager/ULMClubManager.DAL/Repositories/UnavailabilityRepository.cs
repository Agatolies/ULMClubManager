using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class UnavailabilityRepository : GenericRepository<IndDBRow, int, Unavailability>
    {
        public UnavailabilityRepository(IUnitOfWork unitOfWork, UnavailabilityMapper mapper)
            : base(unitOfWork, "IND", mapper)
        {
        }
    }
}
