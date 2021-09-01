using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class BookingDeadlineException : BusinessException

    {
        public BookingDeadlineException()
            : base(ContextError.RES, "BS_RES_DEADLINE")
        {

        }

        protected BookingDeadlineException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public BookingDeadlineException(string message)
            : base(message)
        {
        }

        public BookingDeadlineException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
