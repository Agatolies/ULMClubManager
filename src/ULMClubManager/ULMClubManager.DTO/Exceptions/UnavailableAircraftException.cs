using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{

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
    }
}
