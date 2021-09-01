using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidLicenceDatesException : BusinessException
    {
        public InvalidLicenceDatesException()
            : base(ContextError.MBR, "PIL_LIC_DTE_INVALID")
        {
        }

        protected InvalidLicenceDatesException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public InvalidLicenceDatesException(string message) 
            : base(message)
        {
        }

        public InvalidLicenceDatesException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
