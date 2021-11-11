using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception qu'on ne peut 
    /// pas avoir de qualification sans licence
    /// </summary>
    [Serializable]
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

        protected QualificationWithoutLicenceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
