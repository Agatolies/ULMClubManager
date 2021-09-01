using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LoginAdminException : BusinessException
    {
        public LoginAdminException()
            : base(ContextError.MBR, "ERR_ADMIN")
        {
        }

        protected LoginAdminException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public LoginAdminException(string message)
            : base(message)
        {
        }

        public LoginAdminException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
