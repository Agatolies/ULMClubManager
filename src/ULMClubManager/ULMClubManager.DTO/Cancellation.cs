using System;

namespace ULMClubManager.DTO
{
    public class Cancellation
    {
        public Cancellation(int bookingID, string reason)
        {
            BookingID = bookingID;
            Reason = reason;
        }

        public int BookingID { get; }
        public string Reason { get; }

        public override string ToString()
        {
            return $"Annulation pour motif : {Reason}";
        }
    }
}
