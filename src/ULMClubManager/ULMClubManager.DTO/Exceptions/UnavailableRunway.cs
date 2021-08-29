using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class UnavailableRunway : BusinessException
    {
        public UnavailableRunway()
            : base(ContextError.RES, "BS_RES_PIST_UNAVAILABLE")
        {
        }
    }
}
