using System;

namespace ULMClubManager.DTO
{
    public class Cancellation
    {
        public Cancellation(int id, string reason, DateTime date, string hour)
        {
            ID = id;
            Reason = reason;
            Date = date;
            Hour = hour;
        }

        public int ID { get; }
        public string Reason { get; }
        public DateTime Date { get; }
        public string Hour { get; }

        public override string ToString()
        {
            return $"Annulation pour motif : {Reason}";
        }
    }
}
