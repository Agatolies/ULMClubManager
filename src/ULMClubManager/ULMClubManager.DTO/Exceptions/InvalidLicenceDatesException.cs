using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidLicenceDatesException : BusinessException
    {
        public InvalidLicenceDatesException()
            : base(ContextError.MBR, "PIL_LIC_DTE_INVALID")
        {
        }
    }
}
