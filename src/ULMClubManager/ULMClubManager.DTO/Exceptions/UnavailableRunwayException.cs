using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception pour une piste indisponible
    /// </summary>
    [Serializable]
    public class UnavailableRunwayException : BusinessException
    {
        public UnavailableRunwayException()
            : base(ContextError.RES, "BS_RES_PIST_UNAVAILABLE")
        {
        }

        protected UnavailableRunwayException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public UnavailableRunwayException(string message)
            : base(message)
        {
        }

        public UnavailableRunwayException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

        protected UnavailableRunwayException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
        }
    }
}
