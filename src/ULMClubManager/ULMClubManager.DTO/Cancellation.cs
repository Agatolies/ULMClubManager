using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Cancellation : IDomainModel
    {
        public Cancellation(int? id, string reason, DateTime date, string hour)
        {

        }

        public Cancellation(string reason, DateTime date, string hour)
            : this(null, reason, date, hour)
        {
        }

        public int? ID { get; set; }
        public string Reason { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }

        public override string ToString()
        {
            return $"Annulation pour motif : {Reason}";
        }
    }
}
