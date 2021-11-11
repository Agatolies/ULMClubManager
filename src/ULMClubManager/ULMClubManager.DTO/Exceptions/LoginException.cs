using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions;

/// <summary>
/// Représente une exception pour une mauvaise 
/// combinaison nom d'utilisateur / mot de passe
/// </summary>
[Serializable]
public class LoginException : DataAccessException
{
    public LoginException() 
        : base(ContextError.MBR, "ERR_LOGIN")
    {
    }

    protected LoginException(ContextError context, string tokenError)
        : base(context, tokenError)
    {
    }

    public LoginException(string message)
        : base(message)
    {
    }

    public LoginException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }

    protected LoginException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}