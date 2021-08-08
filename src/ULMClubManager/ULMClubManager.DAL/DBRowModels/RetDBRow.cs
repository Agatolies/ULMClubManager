using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DAL.DBRowModels
{
    public class RetDBRow
    {
        public int RET_ID { get; set; }
        public DateTime RET_DTE_DEB { get; set; }
        public DateTime RET_DTE_FIN { get; set; }
        public string RET_MOTIF { get; set; }
        public int MBR_ID { get; set; }
    }
}
