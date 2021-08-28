using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DAL.DBRowModels
{
    public class MbrDBRow
    {
        public int MBR_ID { get; set; }
        public string MBR_NOM { get; set; }
        public string MBR_PRN { get; set; }
        public string MBR_SEX { get; set; }
        public DateTime MBR_DTE_NAI { get; set; }
        public DateTime MBR_DTE_INS { get; set; }
        public string MBR_RUE { get; set; }
        public string MBR_NOM_RES { get; set; }
        public string MBR_NUM_IMM { get; set; }
        public string MBR_NUM_BTE { get; set; }
        public string MBR_NUM_TEL { get; set; }
        public string MBR_NUM_GSM { get; set; }
        public string MBR_ADR_MAIL { get; set; }
        public bool MBR_ADM { get; set; }
        public string MBR_USR_PSD { get; set; }
        public string MBR_USR_PWD { get; set; }
        public int LOC_FK_ID { get; set; }
        public int MBR_QUAL_TYP_1 { get; set; }
        public int MBR_QUAL_TYP_2 { get; set; }
        public int MBR_QUAL_TYP_3 { get; set; }
        public int MBR_QUAL_TYP_4 { get; set; }
        public int MBR_QUAL_TYP_5 { get; set; }
        public int MBR_QUAL_TYP_6 { get; set; }
        public string PIL_NUM_LIC { get; set; }
        public DateTime? PIL_LIC_DTE_OBT { get; set; }
        public DateTime? PIL_LIC_DTE_EXP { get; set; }
        public string PIL_LIC_PAYS { get; set; }
    }
}
