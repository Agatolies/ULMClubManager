using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Subscription : IDomainModel
    {
        public Subscription(int? id, DateTime issueDate, DateTime paymentDate, decimal fee, int memberID)
        {
            ID = id;
            IssueDate = issueDate;
            PaymentDate = paymentDate;
            Fee = fee;
            MemberID = memberID;
        }

        public Subscription(DateTime issueDate, DateTime paymentDate, decimal fee, int memberID)
            : this(null, issueDate, paymentDate, fee, memberID)
        {
        }

        public int? ID { get; }
        public DateTime IssueDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Fee { get; set; }
        public int MemberID { get; set; }

        public override string ToString()
        {
            return $"Cotisation émise au {IssueDate:d} pour un montant de {Fee}";
        }
    }
}
