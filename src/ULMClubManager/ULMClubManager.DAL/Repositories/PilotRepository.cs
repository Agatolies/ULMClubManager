using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class PilotRepository : GenericRepository<PilDBRow, int, Pilot>
    {
        public PilotRepository(IUnitOfWork unitOfWork, PilotMapper mapper)
            : base(unitOfWork, "PIL", "MBR", mapper)
        {
        }
    }
}
