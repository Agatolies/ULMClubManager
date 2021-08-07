using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Models;

namespace ULMClubManager.DAL.Repositories
{
    public class PistRepository : GenericRepository<Pist, int>
    {
        public PistRepository(string connectionString) 
            : base(connectionString, "PIST")
        {
        }
    }
}
