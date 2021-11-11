using Dapper;
using System.Data;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.DAL.Repositories;

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
        IEnumerable<MbrDBRow> models = _unitOfWork.Connection.Query<MbrDBRow>(
            "sp_select_MBR",
            transaction: _unitOfWork.Transaction);

        return _memberMapper.From(models);
    }

    public Member ReadOne(int memberID)
    {
        MbrDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<MbrDBRow>(
            "sp_select_MBR_BY_ID",
            param: new { MBR_ID = memberID },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        if (result == null)
            throw new KeyNotFoundException($"La table MBR avec l'id [{memberID}] n'existe pas.");

        return _memberMapper.From(result);
    }

    public Member ReadLast()
    {
        MbrDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<MbrDBRow>(
            "sp_select_MBR_LAST",
            transaction: _unitOfWork.Transaction);

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
                MBR_NOM = domainModel.LastName.ToUpper(),
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
                LOC_FK_ID = domainModel.LocalityID,
                MBR_QUAL_TYP_1 = domainModel.QualificationType1 ? 1 : 0,
                MBR_QUAL_TYP_2 = domainModel.QualificationType2 ? 1 : 0,
                MBR_QUAL_TYP_3 = domainModel.QualificationType3 ? 1 : 0,
                MBR_QUAL_TYP_4 = domainModel.QualificationType4 ? 1 : 0,
                MBR_QUAL_TYP_5 = domainModel.QualificationType5 ? 1 : 0,
                MBR_QUAL_TYP_6 = domainModel.QualificationType6 ? 1 : 0
            },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);
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
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);
    }

    public void UpdateOne(Member domainModel)
    {
        MbrDBRow param = _memberMapper.To(domainModel);

        if (domainModel.IsPilot)
        {
            _unitOfWork.Connection.Execute(
                "sp_update_PIL",
                param: new
                {
                    MBR_ID = param.MBR_ID,
                    MBR_NOM = param.MBR_NOM,
                    MBR_PRN = param.MBR_PRN,
                    MBR_SEX = param.MBR_SEX,
                    MBR_DTE_NAI = param.MBR_DTE_NAI,
                    MBR_DTE_INS = param.MBR_DTE_INS,
                    MBR_RUE = param.MBR_RUE,
                    MBR_NOM_RES = param.MBR_NOM_RES,
                    MBR_NUM_IMM = param.MBR_NUM_IMM,
                    MBR_NUM_BTE = param.MBR_NUM_BTE,
                    MBR_NUM_TEL = param.MBR_NUM_TEL,
                    MBR_NUM_GSM = param.MBR_NUM_GSM,
                    MBR_ADR_MAIL = param.MBR_ADR_MAIL,
                    MBR_ADM = param.MBR_ADM,
                    MBR_USR_PSD = param.MBR_USR_PSD,
                    MBR_USR_PWD = param.MBR_USR_PWD,
                    COTI_DTE_PAI = param.COTI_DTE_PAI,
                    LOC_FK_ID = param.LOC_FK_ID,
                    PIL_NUM_LIC = param.PIL_NUM_LIC,
                    PIL_LIC_DTE_OBT = param.PIL_LIC_DTE_OBT,
                    PIL_LIC_DTE_EXP = param.PIL_LIC_DTE_EXP,
                    PIL_LIC_PAYS = param.PIL_LIC_PAYS,
                    MBR_QUAL_TYP_1 = param.MBR_QUAL_TYP_1,
                    MBR_QUAL_TYP_2 = param.MBR_QUAL_TYP_2,
                    MBR_QUAL_TYP_3 = param.MBR_QUAL_TYP_3,
                    MBR_QUAL_TYP_4 = param.MBR_QUAL_TYP_4,
                    MBR_QUAL_TYP_5 = param.MBR_QUAL_TYP_5,
                    MBR_QUAL_TYP_6 = param.MBR_QUAL_TYP_6
                },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);
        }
        else if (domainModel.IsSupporter)
        {
            _unitOfWork.Connection.Execute(
                "sp_update_SYM",
                param: new
                {
                    MBR_ID = param.MBR_ID,
                    MBR_NOM = param.MBR_NOM,
                    MBR_PRN = param.MBR_PRN,
                    MBR_SEX = param.MBR_SEX,
                    MBR_DTE_NAI = param.MBR_DTE_NAI,
                    MBR_DTE_INS = param.MBR_DTE_INS,
                    MBR_RUE = param.MBR_RUE,
                    MBR_NOM_RES = param.MBR_NOM_RES,
                    MBR_NUM_IMM = param.MBR_NUM_IMM,
                    MBR_NUM_BTE = param.MBR_NUM_BTE,
                    MBR_NUM_TEL = param.MBR_NUM_TEL,
                    MBR_NUM_GSM = param.MBR_NUM_GSM,
                    MBR_ADR_MAIL = param.MBR_ADR_MAIL,
                    MBR_ADM = param.MBR_ADM,
                    MBR_USR_PSD = param.MBR_USR_PSD,
                    MBR_USR_PWD = param.MBR_USR_PWD,
                    COTI_DTE_PAI = param.COTI_DTE_PAI,
                    LOC_FK_ID = param.LOC_FK_ID
                },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);
        }
    }

    public void DeleteOne(int id)
    {
        Member memberToDelete = ReadOne(id);

        if (memberToDelete.IsPilot)
        {
            _unitOfWork.Connection.Execute(
                "sp_delete_PIL",
                param: new { MBR_ID = id },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);
        }
        else if (memberToDelete.IsSupporter)
        {
            _unitOfWork.Connection.Execute(
                "sp_delete_SYM",
                param: new { MBR_ID = id },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);
        }
    }

    public int Match(string userName, string password)
    {
        const string sql = "SELECT * FROM MBR WHERE MBR_USR_PSD = @USERNAME";

        var member = _unitOfWork.Connection
            .Query(
                sql,
                param: new { USERNAME = userName },
                transaction: _unitOfWork.Transaction)
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