using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Subscription> ReadAllByMemberID(int memberID)
        {
            IEnumerable<CotiDBRow> models = _unitOfWork.Connection.Query<CotiDBRow>(
                "sp_select_COTI_BY_MBR_ID",
                param: new { MBR_ID = memberID},
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);

            return _mapper.From(models);
        }
    }
}
