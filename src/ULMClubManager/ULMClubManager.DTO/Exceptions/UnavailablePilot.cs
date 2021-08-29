using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class UnavailablePilot : BusinessException
    {
        public UnavailablePilot()
            : base(ContextError.RES, "BS_RES_PIL_UNAVAILABLE")
        {
        }
    }
}
