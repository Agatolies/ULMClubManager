using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class QualificationWithoutLicenceException : BusinessException
    {
        public QualificationWithoutLicenceException()
            : base(ContextError.MBR, "BS_PIL_QUAL_LIC")
        {
        }

        protected QualificationWithoutLicenceException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public QualificationWithoutLicenceException(string message)
            : base(message)
        {
        }

        public QualificationWithoutLicenceException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
