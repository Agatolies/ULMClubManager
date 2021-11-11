using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour indiquer que seul l'administrateur 
/// peut se connecter à l'application pour l'instant
/// </summary>
[Serializable]
public class LoginAdminException : BusinessException
{
    public LoginAdminException()
        : base(ContextError.MBR, "ERR_ADMIN")
    {
    }

    protected LoginAdminException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public LoginAdminException(string message)
        : base(message)
    {
    }

    public LoginAdminException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected LoginAdminException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}