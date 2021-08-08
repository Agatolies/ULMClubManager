using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class SubscriptionRepository : GenericRepository<CotiDBRow, int, Subscription>
    {
        public SubscriptionRepository(string connectionString, SubscriptionMapper mapper)
            : base(connectionString, "COTI", mapper)
        {
        }
    }
}
