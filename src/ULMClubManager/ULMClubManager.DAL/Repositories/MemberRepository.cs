using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.DAL.Repositories
{
    public class MemberRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly MemberMapper _memberMapper;

        public MemberRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _memberMapper = new MemberMapper();
        }

        public List<Member> ReadAll()
        {
            IEnumerable<MbrDBRow> models = _unitOfWork.Connection.Query<MbrDBRow>("sp_select_MBR");
            return _memberMapper.From(models);
        }

        public Member ReadOne(int memberID)
        {
            MbrDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<MbrDBRow>(
                "sp_select_MBR_BY_ID",
                param: new { MBR_ID = memberID },
                commandType: CommandType.StoredProcedure);

            if (result == null)
                throw new KeyNotFoundException($"La table MBR avec l'id [{memberID}] n'existe pas.");

            return _memberMapper.From(result);
        }

        public Member ReadLast()
        {
            MbrDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<MbrDBRow>("sp_select_MBR_LAST");
            return _memberMapper.From(result);
        }

        public Member CreateOne(Member domainModel)
        {
            if (domainModel.IsPilot)
            {
                CreateOnePilot(domainModel);
            } 
            else if (domainModel.IsSupporter)
            {
                CreateOneSupporter(domainModel);
            }

            return ReadLast();
        }

        private void CreateOnePilot(Member domainModel)
        {
            _unitOfWork.Connection.Execute(
                "sp_insert_PIL",
                param: new
                {
                    PIL_NUM_LIC = domainModel.LicenceNumber,
                    PIL_LIC_DTE_OBT = domainModel.LicenceObtentionDate,
                    PIL_LIC_DTE_EXP = domainModel.LicenceExpirationDate,
                    PIL_LIC_PAYS = domainModel.LicenceCountry,
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
        }

        private void CreateOneSupporter(Member domainModel)
        {
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
        }

        public void UpdateOne(Member domainModel)
        {
            if (domainModel.IsPilot)
            {
                _unitOfWork.Connection.Execute(
                    "sp_update_PIL",
                    param: _memberMapper.To(domainModel),
                    commandType: CommandType.StoredProcedure);
            }
            else if (domainModel.IsSupporter)
            {
                _unitOfWork.Connection.Execute(
                    "sp_update_SYM",
                    param: _memberMapper.To(domainModel),
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteOne(int id)
        {
            try
            {
                _unitOfWork.Connection.Execute(
                    "sp_delete_PIL",
                    param: new { PIL_ID = id },
                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                _unitOfWork.Connection.Execute(
                    "sp_delete_SYM",
                    param: new { SYM_ID = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public int Match(string userName, string password)
        {
            string sql = $"SELECT * FROM MBR WHERE MBR_USR_PSD = @USERNAME";

            var member = _unitOfWork.Connection
                .Query(sql, new { USERNAME = userName })
                .FirstOrDefault();

            if (member != null)
            {
                return member.MBR_USR_PWD == password
                    ? member.MBR_ID
                    : throw new LoginException();
            }
            else
            {
                throw new LoginException();
            }
        }
    }
}
