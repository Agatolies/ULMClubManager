using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{

    public class InvalidCountryCodeException : BusinessException
    {
        public InvalidCountryCodeException()
            : base(ContextError.MBR, "CHK_PIL_LIC_PAYS")
        {
        }

        protected InvalidCountryCodeException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public InvalidCountryCodeException(string message)
            : base(message)
        {
        }

        public InvalidCountryCodeException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
