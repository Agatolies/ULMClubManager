namespace ULMClubManager.DAL.DBRowModels
{
    public class ResDBRow
    {
        public int RES_ID { get; set; }
        public DateTime RES_DTE { get; set; }
        public TimeSpan RES_HEU_DEB { get; set; }
        public TimeSpan RES_HEU_FIN { get; set; }
        public string ANN_MOTIF { get; set; }
        public DateTime? ANN_DTE { get; set; }
        public TimeSpan? ANN_HEU { get; set; }
        public int MBR_FK_ID { get; set; }
        public int AER_FK_ID { get; set; }
        public int PIST_FK_ID { get; set; }
    }
}
