using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidSubscriptionForBookingException : BusinessException
    {
        public InvalidSubscriptionForBookingException()
            : base(ContextError.RES, "BS_COTI_INVALID")
        {
        }
    }
}
