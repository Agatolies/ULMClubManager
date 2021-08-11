using Dapper;
using System;
using System.Collections.Generic;
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

            string query3 = $@"
                INSERT INTO PIL 
                (
                    PIL.MBR_ID,
                    PIL_NUM_LIC, 
                    PIL_LIC_DTE_OBT, 
                    PIL_LIC_DTE_EXP, 
                    PIL_LIC_PAYS
                ) 
                VALUES 
                (
                    {result.MBR_ID},
                    @PIL_NUM_LIC, 
                    @PIL_LIC_DTE_OBT, 
                    @PIL_LIC_DTE_EXP, 
                    @PIL_LIC_PAYS
                )"; 

            _unitOfWork.Connection.Execute(query3, model);
            
            return ReadLast();
        }

        public override int CreateMany(IEnumerable<Pilot> domainModels)
        {
            throw new NotImplementedException("On ne créera jamais plusieurs pilotes à la fois.");
        }

        public override IEnumerable<Pilot> ReadAll()
        {
            string query = $@"
                SELECT 
                    PIL.MBR_ID,
                    PIL_NUM_LIC, 
                    PIL_LIC_DTE_OBT, 
                    PIL_LIC_DTE_EXP, 
                    PIL_LIC_PAYS,
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
                FROM PIL
                    INNER JOIN MBR
                    ON PIL.MBR_ID = MBR.MBR_ID";

            IEnumerable<PilDBRow> models = _unitOfWork.Connection.Query<PilDBRow>(query);
            return _mapper.From(models);
        }

        public override Pilot ReadOne(int id)
        {
            string query = $@"
                SELECT 
                    PIL.MBR_ID,
                    PIL_NUM_LIC, 
                    PIL_LIC_DTE_OBT, 
                    PIL_LIC_DTE_EXP, 
                    PIL_LIC_PAYS ,
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
                FROM PIL
                    INNER JOIN MBR
                    ON PIL.MBR_ID = MBR.MBR_ID
                WHERE PIL.{_keyPrefix}_ID = @ID";

            PilDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<PilDBRow>(query, new { ID = id });
            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public override Pilot ReadLast()
        {
            string query = $@"
                SELECT TOP 1
                    PIL.MBR_ID,
                    PIL_NUM_LIC, 
                    PIL_LIC_DTE_OBT, 
                    PIL_LIC_DTE_EXP, 
                    PIL_LIC_PAYS ,
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
                FROM PIL
                    INNER JOIN MBR
                    ON PIL.MBR_ID = MBR.MBR_ID
                ORDER BY MBR_ID DESC";

            PilDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<PilDBRow>(query);
            return _mapper.From(result);
        }

        public override void UpdateOne(Pilot domainModel)
        {
            PilDBRow model = _mapper.To(domainModel);

            string query1 = $@"
                UPDATE PIL SET 
                    PIL_NUM_LIC = @PIL_NUM_LIC, 
                    PIL_LIC_DTE_OBT = @PIL_LIC_DTE_OBT, 
                    PIL_LIC_DTE_EXP = @PIL_LIC_DTE_EXP, 
                    PIL_LIC_PAYS = @PIL_LIC_PAYS
                WHERE MBR_ID = @MBR_ID";

            _unitOfWork.Connection.Execute(query1, model);

            string query2 = $@"
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

            _unitOfWork.Connection.Execute(query2, model);
        }
    }
}
