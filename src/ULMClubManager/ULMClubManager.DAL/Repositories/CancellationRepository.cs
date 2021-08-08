using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class CancellationRepository : GenericRepository<AnnDBRow, int, Cancellation>
    {
        public CancellationRepository(string connectionString, CancellationMapper mapper)
            : base(connectionString, "ANN", mapper)
        {
        }
    }
}
