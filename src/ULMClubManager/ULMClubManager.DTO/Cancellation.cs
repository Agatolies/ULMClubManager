using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Cancellation : IDomainModel
    {
        public Cancellation(
            int? bookingID, string reason)
        {
            ID = bookingID;
            Reason = reason;
        }

        public int? ID { get; set; }
        public string Reason { get; }
    }
}
