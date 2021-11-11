using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour une licence expirée
/// </summary>
[Serializable]
public class ExpiredLicenceException : BusinessException
{
    public ExpiredLicenceException()
        : base(ContextError.RES, "BS_RES_LIC")
    {
    }

    protected ExpiredLicenceException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public ExpiredLicenceException(string message)
        : base(message)
    {
    }

    public ExpiredLicenceException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected ExpiredLicenceException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}