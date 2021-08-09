using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class CancellationRepository : GenericRepository<AnnDBRow, int, Cancellation>
    {
        public CancellationRepository(IUnitOfWork unitOfWork, CancellationMapper mapper)
            : base(unitOfWork, "ANN", mapper)
        {
        }
    }
}
