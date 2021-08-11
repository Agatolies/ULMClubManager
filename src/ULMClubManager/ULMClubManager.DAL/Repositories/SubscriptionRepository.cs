using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class SubscriptionRepository : GenericRepository<CotiDBRow, int, Subscription>
    {
        public SubscriptionRepository(IUnitOfWork unitOfWork, SubscriptionMapper mapper)
            : base(unitOfWork, "COTI", mapper)
        {
        }
    }
}
