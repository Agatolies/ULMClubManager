using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidSubscriptionForBooking : BusinessException
    {
        public InvalidSubscriptionForBooking()
            : base(ContextError.RES, "BS_COTI_INVALID")
        {
        }
    }
}
