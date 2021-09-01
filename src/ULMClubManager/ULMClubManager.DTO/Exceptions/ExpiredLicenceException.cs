using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class ExpiredLicenceException : BusinessException
    {
        public ExpiredLicenceException()
            : base(ContextError.RES, "BS_RES_LIC")
        {
        }

        protected ExpiredLicenceException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public ExpiredLicenceException(string message)
            : base(message)
        {
        }

        public ExpiredLicenceException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
