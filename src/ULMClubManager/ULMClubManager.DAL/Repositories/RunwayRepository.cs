using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;

namespace ULMClubManager.DAL.Repositories
{
    public class RunwayRepository : GenericRepository<PistDBRow, int>
    {
        public RunwayRepository(string connectionString) 
            : base(connectionString, "PIST")
        {
        }
    }
}
