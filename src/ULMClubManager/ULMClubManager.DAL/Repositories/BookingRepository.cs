using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

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
