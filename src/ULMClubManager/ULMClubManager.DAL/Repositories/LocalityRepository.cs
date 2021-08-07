using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class LocalityRepository : GenericRepository<LocDBRow, int, Locality>
    {
        public LocalityRepository(string connectionString, LocalityMapper mapper)
            : base(connectionString, "LOC", mapper)
        {
        }
    }
}
