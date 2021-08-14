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
    public class PilotRepository : GenericRepository<PilDBRow, int, Pilot>
    {
        public PilotRepository(IUnitOfWork unitOfWork, PilotMapper mapper)
            : base(unitOfWork, "PIL", "MBR", mapper)
        {
        }

        public override Pilot CreateOne(Pilot domainModel)
        {
            // L'utilisation du mapper n'est pas souhaitée ici.
            // Si nous utilisions le PilotMapper, nous aurions un paramètre
            // "MBR_ID" en trop pour pouvoir executer la procédure stockée.

            _unitOfWork.Connection.Execute(
                "sp_insert_PIL",
                param: new
                {
                    PIL_NUM_LIC = domainModel.LicenceNumber,
                    PIL_LIC_DTE_OBT = domainModel.ObtentionDate,
                    PIL_LIC_DTE_EXP = domainModel.ExpirationDate,
                    PIL_LIC_PAYS = domainModel.Country,
                    MBR_NOM = domainModel.LastName,
                    MBR_PRN = domainModel.FirstName,
                    MBR_SEX = domainModel.Sex,
                    MBR_DTE_NAI = domainModel.DateOfBirth,
                    MBR_DTE_INS = domainModel.RegistrationDate,
                    MBR_RUE = domainModel.Street,
                    MBR_NOM_RES = domainModel.ResidenceName,
                    MBR_NUM_IMM = domainModel.BuildingNumber,
                    MBR_NUM_BTE = domainModel.BoxNumber,
                    MBR_NUM_TEL = domainModel.PhoneNumber,
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

        public override int CreateMany(IEnumerable<Pilot> domainModels)
        {
            throw new NotImplementedException("On ne créera jamais plusieurs pilotes à la fois.");
        }

        public override List<Pilot> ReadAll()
        {
            IEnumerable<PilDBRow> models = _unitOfWork.Connection.Query<PilDBRow>("sp_select_PIL");
            return _mapper.From(models);
        }

        public List<Pilot> ReadAllByNameBegin(string filterName)
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
