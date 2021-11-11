using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour une adresse email invalide
/// </summary>
[Serializable]
public class InvalidEmailAddressException : BusinessException
{
    public InvalidEmailAddressException()
        : base(ContextError.MBR, "BS_MBR_EMAIL")
    {
    }

    protected InvalidEmailAddressException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public InvalidEmailAddressException(string message)
        : base(message)
    {
    }

    public InvalidEmailAddressException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidEmailAddressException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}