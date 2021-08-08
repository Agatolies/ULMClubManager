using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class PilotRepository : GenericRepository<PilDBRow, int, Pilot>
    {
        public PilotRepository(string connectionString, PilotMapper mapper)
            : base(connectionString, "PIL", "MBR", mapper)
        {
        }
    }
}
