using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception pour un pilote indisponible
    /// </summary>
    public class UnavailablePilotException : BusinessException
    {
        public UnavailablePilotException()
            : base(ContextError.RES, "BS_RES_PIL_UNAVAILABLE")
        {
        }

        protected UnavailablePilotException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public UnavailablePilotException(string message)
            : base(message)
        {
        }

        public UnavailablePilotException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
