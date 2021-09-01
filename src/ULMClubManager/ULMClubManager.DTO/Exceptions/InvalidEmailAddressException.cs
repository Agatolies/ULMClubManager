using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidEmailAddressException : BusinessException
    {
        public InvalidEmailAddressException()
            : base(ContextError.MBR, "BS_MBR_EMAIL")
        {
        }

        protected InvalidEmailAddressException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public InvalidEmailAddressException(string message)
            : base(message)
        {
        }

        public InvalidEmailAddressException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
