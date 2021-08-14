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
            // L'utilisation du mapper n'est pas souhaitée ici.
            // Si nous utilisions le SupporterMapper, nous aurions un paramètre
            // "MBR_ID" en trop pour pouvoir executer la procédure stockée.

            _unitOfWork.Connection.Execute(
                "sp_insert_SYM", 
                param: new
                {
                    MBR_NOM = domainModel.LastName,
                    MBR_PRN = domainModel.FirstName,
                    MBR_SEX = domainModel.Sex,
                    MBR_DTE_NAI = domainModel.DateOfBirth,
                    MBR_DTE_INS = domainModel.RegistrationDate,
                    MBR_RUE = domainModel.Street,
                    MBR_NOM_RES = string.IsNullOrEmpty(domainModel.ResidenceName) ? null : domainModel.ResidenceName,
                    MBR_NUM_IMM = string.IsNullOrEmpty(domainModel.BuildingNumber) ? null : domainModel.BuildingNumber,
                    MBR_NUM_BTE = domainModel.BoxNumber,
                    MBR_NUM_TEL = string.IsNullOrEmpty(domainModel.PhoneNumber) ? null : domainModel.PhoneNumber,
                    MBR_NUM_GSM = domainModel.CellphoneNumber,
                    MBR_ADR_MAIL = domainModel.EmailAddress,
                    MBR_ADM = domainModel.Administrator,
                    MBR_USR_PSD = domainModel.UserName,
                    MBR_USR_PWD = domainModel.UserPWD,
                    LOC_FK_ID = domainModel.LocalityID
                },
                commandType: CommandType.StoredProcedure);

            return ReadLast();
        }

        public override List<Supporter> ReadAll()
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
