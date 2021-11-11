using System.Runtime.Serialization;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Classe abstraite dont les exceptions en héritant sont levées dans la Data Access Layer
    /// </summary>
    [Serializable]
    public abstract class DataAccessException : Exception
    {
        protected DataAccessException(ContextError context, string tokenError)
        {
            Context = context;
            TokenError = tokenError;
        }

        protected DataAccessException()
            : base()
        {
        }

        protected DataAccessException(string message)
            : base(message)
        {
        }

        protected DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected DataAccessException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {
        }

        public ContextError Context { get; }

        public string? TokenError { get;  }
    }
}
