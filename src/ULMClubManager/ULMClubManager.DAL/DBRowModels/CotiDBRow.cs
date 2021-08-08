using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DAL.DBRowModels
{
    public class CotiDBRow
    {
        public int COTI_ID { get; set; }
        public DateTime COTI_DTE_EMI { get; set; }
        public DateTime COTI_DTE_PAI { get; set; }
        public decimal COTI_MONT { get; set; }
        public int MBR_ID { get; set; }
    }
}
