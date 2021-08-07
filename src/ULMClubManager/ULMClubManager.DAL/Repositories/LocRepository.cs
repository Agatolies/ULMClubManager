using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Models;

namespace ULMClubManager.DAL.Repositories
{
    public class LocRepository : GenericRepository<Loc, int>
    {
        public LocRepository(string connectionString)
            : base(connectionString, "LOC")
        {
        }
    }
}
