using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class SupporterMapper : GenericMapper<SymDBRow, Supporter>
    {
        public override Supporter From(SymDBRow sym)
        {
            Qualification qualification = new Qualification(
                sym.MBR_QUAL_TYP_1 == 1,
                sym.MBR_QUAL_TYP_2 == 1,
                sym.MBR_QUAL_TYP_3 == 1,
                sym.MBR_QUAL_TYP_4 == 1,
                sym.MBR_QUAL_TYP_5 == 1,
                sym.MBR_QUAL_TYP_6 == 1);

            return new Supporter(
                 sym.MBR_ID,
                 sym.MBR_NOM,
                 sym.MBR_PRN,
                 sym.MBR_SEX,
                 sym.MBR_DTE_NAI,
                 sym.MBR_DTE_INS,
                 sym.MBR_RUE,
                 sym.MBR_NOM_RES,
                 sym.MBR_NUM_IMM,
                 sym.MBR_NUM_BTE,
                 sym.MBR_NUM_TEL,
                 sym.MBR_NUM_GSM,
                 sym.MBR_ADR_MAIL,
                 sym.MBR_ADM,
                 sym.MBR_USR_PSD,
                 sym.MBR_USR_PWD,
                 sym.LOC_FK_ID,
                 qualification
            );
        }

        public override SymDBRow To(Supporter sym)
        {
            SymDBRow result = new SymDBRow();

            if (sym.ID.HasValue)
                result.MBR_ID = sym.ID.Value;

            result.MBR_NOM = sym.LastName;
            result.MBR_PRN = sym.FirstName;
            result.MBR_SEX = sym.Sex;
            result.MBR_DTE_NAI = sym.DateOfBirth;
            result.MBR_DTE_INS = sym.RegistrationDate;
            result.MBR_RUE = sym.Street;
            result.MBR_NOM_RES = sym.ResidenceName;
            result.MBR_NUM_IMM = sym.BuildingNumber;
            result.MBR_NUM_BTE = sym.BoxNumber;
            result.MBR_NUM_TEL = sym.PhoneNumber;
            result.MBR_NUM_GSM = sym.CellphoneNumber;
            result.MBR_ADR_MAIL = sym.EmailAddress;
            result.MBR_ADM = sym.Administrator;
            result.MBR_USR_PSD = sym.UserName;
            result.MBR_USR_PWD = sym.UserPWD;
            result.LOC_FK_ID = sym.LocalityID;
            result.MBR_QUAL_TYP_1 = sym.Qualification.Type1 ? 1 : 0;
            result.MBR_QUAL_TYP_2 = sym.Qualification.Type2 ? 1 : 0;
            result.MBR_QUAL_TYP_3 = sym.Qualification.Type3 ? 1 : 0;
            result.MBR_QUAL_TYP_4 = sym.Qualification.Type4 ? 1 : 0;
            result.MBR_QUAL_TYP_5 = sym.Qualification.Type5 ? 1 : 0;
            result.MBR_QUAL_TYP_6 = sym.Qualification.Type6 ? 1 : 0;

            return result;
        }
    }
}
