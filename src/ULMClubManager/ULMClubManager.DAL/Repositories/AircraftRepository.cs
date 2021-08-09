using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class AircraftRepository : GenericRepository<AerDBRow, int, Aircraft>
    {
        public AircraftRepository(IUnitOfWork unitOfWork, AircraftMapper mapper)
            : base(unitOfWork, "AER", mapper)
        {
        }
    }
}
