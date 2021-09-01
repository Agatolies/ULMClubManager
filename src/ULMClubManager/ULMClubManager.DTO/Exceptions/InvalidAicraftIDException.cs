using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{

    public class InvalidAicraftIDException : BusinessException
    {
        public InvalidAicraftIDException()
            : base(ContextError.RES, "BS_AER_ID")
        {
        }

        protected InvalidAicraftIDException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public InvalidAicraftIDException(string message)
            : base(message)
        {
        }

        public InvalidAicraftIDException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
