using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception pour signaler 
    /// qu'une licence doit avoir au minimum une qualification
    /// </summary>
    public class LicenceWithoutQualificationsException : BusinessException
    {
        public LicenceWithoutQualificationsException()
            : base(ContextError.MBR, "BS_PIL_LIC_QUAL")
        {
        }

        protected LicenceWithoutQualificationsException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public LicenceWithoutQualificationsException(string message)
            : base(message)
        {
        }

        public LicenceWithoutQualificationsException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
