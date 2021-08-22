using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidCountryCode : BusinessException
    {
        public InvalidCountryCode()
            : base(ContextError.MBR, "CHK_PIL_LIC_PAYS")
        {
        }
    }
}
