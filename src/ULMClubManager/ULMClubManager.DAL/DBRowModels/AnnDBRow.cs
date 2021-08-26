using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DAL.DBRowModels
{
    public class AnnDBRow
    {
        public int RES_FK_ID { get; set; }
        public string ANN_MOTIF { get; set; }
        public DateTime ANN_DTE{ get; set; }
        public TimeSpan ANN_HEU { get; set; }
        public int AER_FK_ID { get; set; }
    }
}
