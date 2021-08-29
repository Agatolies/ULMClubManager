using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class UnavailablePilotException : BusinessException
    {
        public UnavailablePilotException()
            : base(ContextError.RES, "BS_RES_PIL_UNAVAILABLE")
        {
        }
    }
}
