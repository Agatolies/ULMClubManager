﻿using System;
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
    }
}
