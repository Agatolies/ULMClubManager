using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Models;

namespace ULMClubManager.DAL.Repositories
{
    public class IndRepository : GenericRepository<Ind, int>
    {
        public IndRepository(string connectionString)
            : base(connectionString, "IND")
        {
        }
    }
}
