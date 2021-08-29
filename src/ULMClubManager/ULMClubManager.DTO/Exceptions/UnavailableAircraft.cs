using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class UnavailableAircraft : BusinessException
    {
        public UnavailableAircraft()
            : base(ContextError.RES, "BS_RES_AER_UNAVAILABLE")
        {
        }
    }
}
