using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Classe abstraite dont les exceptions en héritant sont levées dans la Business Layer
    /// </summary>
    public abstract class BusinessException : Exception
    {
        protected BusinessException(ContextError context, string tokenError)
        {
            Context = context;
            TokenError = tokenError;
        }

        protected BusinessException()
        {
        }

        protected BusinessException(string message)
            : base(message)
        {
        }

        protected BusinessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected BusinessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ContextError Context { get; }

        public string? TokenError { get;  }
    }
}
