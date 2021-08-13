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
    public class SupporterRepository : GenericRepository<SymDBRow, int, Supporter>
    {
        public SupporterRepository(IUnitOfWork unitOfWork, SupporterMapper mapper)
            : base(unitOfWork, "PIL", "SYM", mapper)
        {
        }

        public override Supporter CreateOne(Supporter domainModel)
        {
            SymDBRow model = _mapper.To(domainModel);

            _unitOfWork.Connection.Execute(
                "sp_insert_SYM", 
                param: model,
                commandType: CommandType.StoredProcedure);

            return ReadLast();
        }

        public override int CreateMany(IEnumerable<Supporter> domainModels)
        {
            throw new NotImplementedException("On ne créera jamais plusieurs sympathisants à la fois.");
        }

        public override IEnumerable<Supporter> ReadAll()
        {
            IEnumerable<SymDBRow> models = _unitOfWork.Connection.Query<SymDBRow>("sp_select_SYM");
            return _mapper.From(models);
        }

        public override Supporter ReadOne(int id)
        {
            SymDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<SymDBRow>(
                "sp_select_SYM_BY_ID", 
                param: new { MBR_ID = id },
                commandType: CommandType.StoredProcedure);

            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public override Supporter ReadLast()
        {
            SymDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<SymDBRow>("sp_select_SYM_LAST");
            return _mapper.From(result);
        }

        public override void UpdateOne(Supporter domainModel)
        {
            SymDBRow model = _mapper.To(domainModel);

            _unitOfWork.Connection.Execute(
                "sp_update_SYM", 
                param: model,
                commandType: CommandType.StoredProcedure);
        }
    }
}
