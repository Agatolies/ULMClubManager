using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour un membre qui n'est pas en ordre de cotisation
/// </summary>
[Serializable]
public class InvalidSubscriptionForBookingException : BusinessException
{
    public InvalidSubscriptionForBookingException()
        : base(ContextError.RES, "BS_COTI_INVALID")
    {
    }

    protected InvalidSubscriptionForBookingException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public InvalidSubscriptionForBookingException(string message)
        : base(message)
    {
    }

    public InvalidSubscriptionForBookingException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected InvalidSubscriptionForBookingException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}