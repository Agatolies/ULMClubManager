using System;

namespace ULMClubManager.DAL.Models
{
    public class Ind
    {
        public int IND_ID { get; set; }
        public DateTime IND_DTE_DEB { get; set; }
        public string IND_HEU_DEB { get; set; }
        public DateTime IND_DTE_FIN { get; set; }
        public string IND_HEU_FIN { get; set; }
        public string IND_DES { get; set; }
        public int AER_ID { get; set; }
    }
}
