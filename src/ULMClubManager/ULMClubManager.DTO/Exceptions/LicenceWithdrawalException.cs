using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception pour une réservation impossible
    /// à cause d'un retrait de licence
    /// </summary>
    [Serializable]
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

        protected LicenceWithdrawalException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
