using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception pour un ULM indisponible
    /// </summary>
    [Serializable]
    public class UnavailableAircraftException : BusinessException
    {
        public UnavailableAircraftException()
            : base(ContextError.RES, "BS_RES_AER_UNAVAILABLE")
        {
        }

        protected UnavailableAircraftException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public UnavailableAircraftException(string message)
            : base(message)
        {
        }

        public UnavailableAircraftException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }

        protected UnavailableAircraftException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
