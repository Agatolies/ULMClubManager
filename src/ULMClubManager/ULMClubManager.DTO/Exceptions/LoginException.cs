using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LoginException : DataAccessException
    {
        public LoginException() 
            : base(ContextError.MBR, "ERR_LOGIN")
        {
        }

        protected LoginException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public LoginException(string message)
            : base(message)
        {
        }

        public LoginException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
