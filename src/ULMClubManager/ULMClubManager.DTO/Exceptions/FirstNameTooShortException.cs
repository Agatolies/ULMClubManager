using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{

    public class FirstNameTooShortException : BusinessException
    {
        public FirstNameTooShortException()
            : base(ContextError.MBR, "BS_MBR_PRN")
        {
        }

        protected FirstNameTooShortException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public FirstNameTooShortException(string message)
            : base(message)
        {
        }

        public FirstNameTooShortException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
