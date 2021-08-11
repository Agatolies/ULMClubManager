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
                 sym.LOC_ID
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
            result.LOC_ID = sym.LocalityID;

            return result;
        }
    }
}
