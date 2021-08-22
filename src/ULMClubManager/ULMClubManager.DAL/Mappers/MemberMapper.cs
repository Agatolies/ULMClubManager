using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class MemberMapper
    {
        public Member From(MbrDBRow mbr) {
            Qualification qualification = new Qualification(
                mbr.MBR_QUAL_TYP_1 == 1,
                mbr.MBR_QUAL_TYP_2 == 1,
                mbr.MBR_QUAL_TYP_3 == 1,
                mbr.MBR_QUAL_TYP_4 == 1,
                mbr.MBR_QUAL_TYP_5 == 1,
                mbr.MBR_QUAL_TYP_6 == 1);

            return new Member(
                mbr.MBR_ID,
                mbr.PIL_NUM_LIC,
                mbr.PIL_LIC_DTE_OBT,
                mbr.PIL_LIC_DTE_EXP,
                mbr.PIL_LIC_PAYS,
                mbr.MBR_NOM,
                mbr.MBR_PRN,
                mbr.MBR_SEX,
                mbr.MBR_DTE_NAI,
                mbr.MBR_DTE_INS,
                mbr.MBR_RUE,
                mbr.MBR_NOM_RES,
                mbr.MBR_NUM_IMM,
                mbr.MBR_NUM_BTE,
                mbr.MBR_NUM_TEL,
                mbr.MBR_NUM_GSM,
                mbr.MBR_ADR_MAIL,
                mbr.MBR_ADM,
                mbr.MBR_USR_PSD,
                mbr.MBR_USR_PWD,
                mbr.LOC_FK_ID,
                qualification
            );
        }

        public List<Member> From(IEnumerable<MbrDBRow> models)
        {
            return models
                .Select(model => From(model))
                .ToList();
        }

        public MbrDBRow To(Member member)
        {
            MbrDBRow result = new MbrDBRow();

            if (member.ID.HasValue)
                result.MBR_ID = member.ID.Value;

            result.PIL_NUM_LIC = member.LicenceNumber;
            result.PIL_LIC_DTE_OBT = member.LicenceObtentionDate;
            result.PIL_LIC_DTE_EXP = member.LicenceExpirationDate;
            result.PIL_LIC_PAYS = member.LicenceCountry;
            result.MBR_NOM = member.LastName;
            result.MBR_PRN = member.FirstName;
            result.MBR_SEX = member.Sex;
            result.MBR_DTE_NAI = member.DateOfBirth;
            result.MBR_DTE_INS = member.RegistrationDate;
            result.MBR_RUE = member.Street;
            result.MBR_NOM_RES = member.ResidenceName;
            result.MBR_NUM_IMM = member.BuildingNumber;
            result.MBR_NUM_BTE = member.BoxNumber;
            result.MBR_NUM_TEL = member.PhoneNumber;
            result.MBR_NUM_GSM = member.CellphoneNumber;
            result.MBR_ADR_MAIL = member.EmailAddress;
            result.MBR_ADM = member.Administrator;
            result.MBR_USR_PSD = member.UserName;
            result.MBR_USR_PWD = member.UserPWD;
            result.LOC_FK_ID = member.LocalityID;
            result.MBR_QUAL_TYP_1 = member.Qualification.Type1 ? 1 : 0;
            result.MBR_QUAL_TYP_2 = member.Qualification.Type2 ? 1 : 0;
            result.MBR_QUAL_TYP_3 = member.Qualification.Type3 ? 1 : 0;
            result.MBR_QUAL_TYP_4 = member.Qualification.Type4 ? 1 : 0;
            result.MBR_QUAL_TYP_5 = member.Qualification.Type5 ? 1 : 0;
            result.MBR_QUAL_TYP_6 = member.Qualification.Type6 ? 1 : 0;

            return result;
        }
    }
}
