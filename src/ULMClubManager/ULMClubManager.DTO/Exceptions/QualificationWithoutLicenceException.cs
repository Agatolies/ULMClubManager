using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class QualificationWithoutLicenceException : BusinessException
    {
        public QualificationWithoutLicenceException()
            : base(ContextError.MBR, "BS_PIL_QUAL_LIC")
        {
        }
    }
}
