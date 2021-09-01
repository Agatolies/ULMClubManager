using Dapper;
using System.Collections.Generic;
using System.Data;
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

        public List<Withdrawal> ReadAllWithdrawalsByPilotID(int pilotID)
        {
            IEnumerable<RetDBRow> models = _unitOfWork.Connection.Query<RetDBRow>(
             "sp_select_RET_BY_MBR_ID",
             param: new { MBR_ID = pilotID },
             commandType: CommandType.StoredProcedure,
             transaction: _unitOfWork.Transaction);

            return _mapper.From(models);
        }
    }
}
