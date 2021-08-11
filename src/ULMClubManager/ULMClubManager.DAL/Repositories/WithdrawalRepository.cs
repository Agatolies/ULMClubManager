using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class WithdrawalRepository : GenericRepository<RetDBRow, int, Withdrawal>
    {
        public WithdrawalRepository(IUnitOfWork unitOfWork, WithdrawalMapper mapper)
            : base(unitOfWork, "RET", mapper)
        {
        }
    }
}
