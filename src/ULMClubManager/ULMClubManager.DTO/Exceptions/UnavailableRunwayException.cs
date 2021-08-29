using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class UnavailableRunwayException : BusinessException
    {
        public UnavailableRunwayException()
            : base(ContextError.RES, "BS_RES_PIST_UNAVAILABLE")
        {
        }
    }
}
