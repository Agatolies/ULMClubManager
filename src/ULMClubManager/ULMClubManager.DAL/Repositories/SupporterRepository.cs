using System;
using System.Collections.Generic;
using System.Linq;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Repositories
{
    public class SupporterRepository : GenericRepository<SymDBRow, int, Supporter>
    {
        public SupporterRepository(IUnitOfWork unitOfWork, SupporterMapper mapper)
            : base(unitOfWork, "PIL", "SYM", mapper)
        {
        }
    }
}
