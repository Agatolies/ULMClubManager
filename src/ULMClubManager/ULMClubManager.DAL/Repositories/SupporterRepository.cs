using Dapper;
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

        public override Supporter CreateOne(Supporter domainModel)
        {
            SymDBRow model = _mapper.To(domainModel);

            string query1 = $@"
                INSERT INTO MBR 
                (
                    MBR_NOM, 
                    MBR_PRN, 
                    MBR_SEX,
                    MBR_DTE_NAI, 
                    MBR_DTE_INS, 
                    MBR_RUE, 
                    MBR_NOM_RES, 
                    MBR_NUM_IMM,
                    MBR_NUM_BTE, 
                    MBR_NUM_TEL, 
                    MBR_NUM_GSM, 
                    MBR_ADR_MAIL, 
                    MBR_ADM, 
                    MBR_USR_PSD, 
                    MBR_USR_PWD, 
                    LOC_ID
                ) 
                VALUES 
                (
                    @MBR_NOM,  
                    @MBR_PRN,
                    @MBR_SEX,
                    @MBR_DTE_NAI, 
                    @MBR_DTE_INS, 
                    @MBR_RUE, 
                    @MBR_NOM_RES, 
                    @MBR_NUM_IMM, 
                    @MBR_NUM_BTE, 
                    @MBR_NUM_TEL, 
                    @MBR_NUM_GSM, 
                    @MBR_ADR_MAIL, 
                    @MBR_ADM, 
                    @MBR_USR_PSD, 
                    @MBR_USR_PWD, 
                    @LOC_ID
                )";

            _unitOfWork.Connection.Execute(query1, model);

            string query2 = $"SELECT TOP 1 * FROM MBR ORDER BY MBR_ID DESC";
            MbrDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<MbrDBRow>(query2);

            string query3 = $@"INSERT INTO SYM (SYM.MBR_ID) VALUES ({result.MBR_ID})";
            _unitOfWork.Connection.Execute(query3, model);

            return ReadLast();
        }

        public override int CreateMany(IEnumerable<Supporter> domainModels)
        {
            throw new NotImplementedException("On ne créera jamais plusieurs sympathisants à la fois.");
        }

        public override IEnumerable<Supporter> ReadAll()
        {
            string query = $@"
                SELECT 
                    SYM.MBR_ID,
                    MBR_NOM, 
                    MBR_PRN, 
                    MBR_DTE_NAI, 
                    MBR_DTE_INS, 
                    MBR_RUE, 
                    MBR_NOM_RES, 
                    MBR_NUM_IMM, 
                    MBR_NUM_BTE, 
                    MBR_NUM_TEL, 
                    MBR_NUM_GSM, 
                    MBR_ADR_MAIL, 
                    MBR_ADM, 
                    MBR_USR_PSD, 
                    MBR_USR_PWD, 
                    LOC_ID
                FROM SYM
                    INNER JOIN MBR
                    ON SYM.MBR_ID = MBR.MBR_ID";

            IEnumerable<SymDBRow> models = _unitOfWork.Connection.Query<SymDBRow>(query);
            return _mapper.From(models);
        }

        public override Supporter ReadOne(int id)
        {
            string query = $@"
                SELECT 
                    SYM.MBR_ID,
                    MBR_NOM, 
                    MBR_PRN, 
                    MBR_DTE_NAI, 
                    MBR_DTE_INS, 
                    MBR_RUE, 
                    MBR_NOM_RES, 
                    MBR_NUM_IMM, 
                    MBR_NUM_BTE, 
                    MBR_NUM_TEL, 
                    MBR_NUM_GSM, 
                    MBR_ADR_MAIL, 
                    MBR_ADM, 
                    MBR_USR_PSD, 
                    MBR_USR_PWD, 
                    LOC_ID
                FROM SYM
                    INNER JOIN MBR
                    ON SYM.MBR_ID = MBR.MBR_ID
                WHERE SYM.{_keyPrefix}_ID = @ID";

            SymDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<SymDBRow>(query, new { ID = id });
            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public override Supporter ReadLast()
        {
            string query = $@"
                SELECT TOP 1
                    SYM.MBR_ID,
                    MBR_NOM, 
                    MBR_PRN, 
                    MBR_DTE_NAI, 
                    MBR_DTE_INS, 
                    MBR_RUE, 
                    MBR_NOM_RES, 
                    MBR_NUM_IMM, 
                    MBR_NUM_BTE, 
                    MBR_NUM_TEL, 
                    MBR_NUM_GSM, 
                    MBR_ADR_MAIL, 
                    MBR_ADM, 
                    MBR_USR_PSD, 
                    MBR_USR_PWD, 
                    LOC_ID
                FROM SYM
                    INNER JOIN MBR
                    ON SYM.MBR_ID = MBR.MBR_ID
                ORDER BY MBR_ID DESC";

            SymDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<SymDBRow>(query);
            return _mapper.From(result);
        }

        public override void UpdateOne(Supporter domainModel)
        {
            string query = $@"
                UPDATE MBR SET 
                    MBR_NOM = @MBR_NOM, 
                    MBR_PRN = @MBR_PRN, 
                    MBR_SEX = @MBR_SEX,
                    MBR_DTE_NAI = @MBR_DTE_NAI, 
                    MBR_DTE_INS = @MBR_DTE_INS, 
                    MBR_RUE = @MBR_RUE, 
                    MBR_NOM_RES = @MBR_NOM_RES, 
                    MBR_NUM_IMM = @MBR_NUM_IMM,
                    MBR_NUM_BTE = @MBR_NUM_BTE, 
                    MBR_NUM_TEL = @MBR_NUM_TEL, 
                    MBR_NUM_GSM = @MBR_NUM_GSM, 
                    MBR_ADR_MAIL = @MBR_ADR_MAIL, 
                    MBR_ADM = @MBR_ADM, 
                    MBR_USR_PSD = @MBR_USR_PSD, 
                    MBR_USR_PWD = @MBR_USR_PWD, 
                    LOC_ID = @LOC_ID
                WHERE MBR_ID = @MBR_ID";

            SymDBRow model = _mapper.To(domainModel);
            _unitOfWork.Connection.Execute(query, model);
        }
    }
}
