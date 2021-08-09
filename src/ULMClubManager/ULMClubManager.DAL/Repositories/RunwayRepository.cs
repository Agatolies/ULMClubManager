using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class RunwayRepository : GenericRepository<PistDBRow, int, Runway>
    {
        public RunwayRepository(IUnitOfWork unitOfWork, RunwayMapper mapper) 
            : base(unitOfWork, "PIST", mapper)
        {
        }
    }
}
