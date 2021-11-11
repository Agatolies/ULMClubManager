namespace ULMClubManager.DAL.DBRowModels;

public class RetDBRow
{
    public int RET_ID { get; set; }
    public DateTime RET_DTE_DEB { get; set; }
    public DateTime RET_DTE_FIN { get; set; }
    public string? RET_MOTIF { get; set; }
    public int MBR_FK_ID { get; set; }
}