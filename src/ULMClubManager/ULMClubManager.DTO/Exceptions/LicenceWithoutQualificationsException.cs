using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LicenceWithoutQualificationsException : BusinessException
    {
        public LicenceWithoutQualificationsException()
            : base(ContextError.MBR, "BS_PIL_LIC_QUAL")
        {
        }
    }
}
