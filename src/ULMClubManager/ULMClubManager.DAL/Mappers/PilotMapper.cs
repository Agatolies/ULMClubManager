using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class PilotMapper : GenericMapper<PilDBRow, Pilot>
    {
        public override Pilot From(PilDBRow pil)
        {
            Qualification qualification = new Qualification(
                pil.MBR_QUAL_TYP_1 == 1,
                pil.MBR_QUAL_TYP_2 == 1,
                pil.MBR_QUAL_TYP_3 == 1,
                pil.MBR_QUAL_TYP_4 == 1,
                pil.MBR_QUAL_TYP_5 == 1,
                pil.MBR_QUAL_TYP_6 == 1);

            return new Pilot(
                pil.MBR_ID,
                pil.PIL_NUM_LIC,
                pil.PIL_LIC_DTE_OBT,
                pil.PIL_LIC_DTE_EXP,
                pil.PIL_LIC_PAYS,
                pil.MBR_NOM,
                pil.MBR_PRN,
                pil.MBR_SEX,
                pil.MBR_DTE_NAI,
                pil.MBR_DTE_INS,
                pil.MBR_RUE,
                pil.MBR_NOM_RES,
                pil.MBR_NUM_IMM,
                pil.MBR_NUM_BTE,
                pil.MBR_NUM_TEL,
                pil.MBR_NUM_GSM,
                pil.MBR_ADR_MAIL,
                pil.MBR_ADM,
                pil.MBR_USR_PSD,
                pil.MBR_USR_PWD,
                pil.LOC_FK_ID,
                qualification
            ) ;
        }

        public override PilDBRow To(Pilot pil)
        {
            PilDBRow result = new PilDBRow();

            if (pil.ID.HasValue)
                result.MBR_ID = pil.ID.Value;

            result.PIL_NUM_LIC = pil.LicenceNumber;
            result.PIL_LIC_DTE_OBT = pil.ObtentionDate;
            result.PIL_LIC_DTE_EXP = pil.ExpirationDate;
            result.PIL_LIC_PAYS = pil.Country;
            result.MBR_NOM = pil.LastName;
            result.MBR_PRN = pil.FirstName;
            result.MBR_SEX = pil.Sex;
            result.MBR_DTE_NAI = pil.DateOfBirth;
            result.MBR_DTE_INS = pil.RegistrationDate;
            result.MBR_RUE = pil.Street;
            result.MBR_NOM_RES = pil.ResidenceName;
            result.MBR_NUM_IMM = pil.BuildingNumber;
            result.MBR_NUM_BTE = pil.BoxNumber;
            result.MBR_NUM_TEL = pil.PhoneNumber;
            result.MBR_NUM_GSM = pil.CellphoneNumber;
            result.MBR_ADR_MAIL = pil.EmailAddress;
            result.MBR_ADM = pil.Administrator;
            result.MBR_USR_PSD = pil.UserName;
            result.MBR_USR_PWD = pil.UserPWD;
            result.LOC_FK_ID = pil.LocalityID;
            result.MBR_QUAL_TYP_1 = pil.Qualification.Type1 ? 1 : 0;
            result.MBR_QUAL_TYP_2 = pil.Qualification.Type2 ? 1 : 0;
            result.MBR_QUAL_TYP_3 = pil.Qualification.Type3 ? 1 : 0;
            result.MBR_QUAL_TYP_4 = pil.Qualification.Type4 ? 1 : 0;
            result.MBR_QUAL_TYP_5 = pil.Qualification.Type5 ? 1 : 0;
            result.MBR_QUAL_TYP_6 = pil.Qualification.Type6 ? 1 : 0;

            return result;
        }
    }
}
