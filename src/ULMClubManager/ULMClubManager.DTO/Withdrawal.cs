using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO;

/// <summary>
/// Représente un retrait temporaire de la licence d'un pilote
/// </summary>
public class Withdrawal : IDomainModel
{
    public Withdrawal(int? id, DateTime startDate, DateTime endDate, string reason, int memberID)
    {
        ID = id;
        StartDate = startDate;
        EndDate = endDate;
        Reason = reason;
        MemberID = memberID;
    }

    public Withdrawal(DateTime startDate, DateTime endDate, string Reason, int memberID)
        : this(null, startDate, endDate, Reason, memberID)
    {
    }

    public int? ID { get; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Reason { get; set; }
    public int MemberID { get; set; }

    public override string ToString()
    {
        return $"retrait de la licence du membre {MemberID} du {StartDate} au {EndDate}";
    }
}