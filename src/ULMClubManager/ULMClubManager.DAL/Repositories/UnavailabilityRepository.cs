using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Repositories
{
    public class UnavailabilityRepository : GenericRepository<IndDBRow, int, Unavailability>
    {
        public UnavailabilityRepository(string connectionString)
            : base(connectionString, "IND")
        {
        }
    }
}
