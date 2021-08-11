using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class BookingRepository : GenericRepository<ResDBRow, int, Booking>
    {
        public BookingRepository(IUnitOfWork unitOfWork, BookingMapper mapper)
            : base(unitOfWork, "RES", mapper)
        {
        }
    }
}
