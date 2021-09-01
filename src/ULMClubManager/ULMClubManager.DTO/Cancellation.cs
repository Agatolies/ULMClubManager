using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    /// <summary>
    /// Représente une annulation de réservation
    /// </summary>
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
