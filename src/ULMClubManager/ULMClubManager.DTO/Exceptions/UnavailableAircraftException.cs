using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{

    public class UnavailableAircraftException : BusinessException
    {
        public UnavailableAircraftException()
            : base(ContextError.RES, "BS_RES_AER_UNAVAILABLE")
        {
        }
    }
}
