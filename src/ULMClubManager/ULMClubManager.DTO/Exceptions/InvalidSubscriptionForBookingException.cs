using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidSubscriptionForBookingException : BusinessException
    {
        public InvalidSubscriptionForBookingException()
            : base(ContextError.RES, "BS_COTI_INVALID")
        {
        }

        protected InvalidSubscriptionForBookingException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public InvalidSubscriptionForBookingException(string message)
            : base(message)
        {
        }

        public InvalidSubscriptionForBookingException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
