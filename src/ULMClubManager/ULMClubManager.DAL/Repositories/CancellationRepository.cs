using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

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
