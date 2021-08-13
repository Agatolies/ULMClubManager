using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class PilotRepository : GenericRepository<PilDBRow, int, Pilot>
    {
        public PilotRepository(IUnitOfWork unitOfWork, PilotMapper mapper)
            : base(unitOfWork, "PIL", "MBR", mapper)
        {
        }

        public override Pilot CreateOne(Pilot domainModel)
        {
            PilDBRow model = _mapper.To(domainModel);

            _unitOfWork.Connection.Execute(
                "sp_insert.PIL", 
                param: model,
                commandType: CommandType.StoredProcedure);

            return ReadLast();
        }

        public override int CreateMany(IEnumerable<Pilot> domainModels)
        {
            throw new NotImplementedException("On ne créera jamais plusieurs pilotes à la fois.");
        }

        public override IEnumerable<Pilot> ReadAll()
        {
            IEnumerable<PilDBRow> models = _unitOfWork.Connection.Query<PilDBRow>("sp_select_PIL");
            return _mapper.From(models);
        }

        public IEnumerable<Pilot> ReadAllBy(string filterName)
        {
            IEnumerable<PilDBRow> models = _unitOfWork.Connection.Query<PilDBRow>(
                "sp_select_PIL_NOM_DEB",
                param : new { NOM_DEB = filterName },
                commandType : CommandType.StoredProcedure); 

            return _mapper.From(models);
        }

        public override Pilot ReadOne(int id)
        {
            PilDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<PilDBRow>(
                "sp_select_PIL_BY_ID", 
                param: new { MBR_ID = id },
                commandType: CommandType.StoredProcedure);

            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public override Pilot ReadLast()
        {
            PilDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<PilDBRow>("sp_select_PIL_LAST");
            return _mapper.From(result);
        }

        public override void UpdateOne(Pilot domainModel)
        {
            PilDBRow model = _mapper.To(domainModel);

            _unitOfWork.Connection.Execute(
                "sp_update_PIL", 
                param: model,
                commandType: CommandType.StoredProcedure);
        }
    }
}
