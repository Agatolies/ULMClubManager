using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidCountryCodeException : BusinessException
    {
        public InvalidCountryCodeException()
            : base(ContextError.MBR, "CHK_PIL_LIC_PAYS")
        {
        }
    }
}
