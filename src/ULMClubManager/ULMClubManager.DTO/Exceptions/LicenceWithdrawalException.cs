using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LicenceWithdrawalException : BusinessException
    {
        public LicenceWithdrawalException()
            : base(ContextError.RES, "BS_RES_RET")
        {
        }

        protected LicenceWithdrawalException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public LicenceWithdrawalException(string message)
            : base(message)
        {
        }

        public LicenceWithdrawalException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
