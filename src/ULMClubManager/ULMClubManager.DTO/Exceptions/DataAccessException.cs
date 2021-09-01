using System;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Classe abstraite dont les exceptions en héritant sont levées dans la Data Access Layer
    /// </summary>
    public abstract class DataAccessException : Exception
    {
        protected DataAccessException(ContextError context, string tokenError)
        {
            Context = context;
            TokenError = tokenError;
        }

        public DataAccessException()
            : base()
        {
        }

        public DataAccessException(string message)
            : base(message)
        {
        }

        public DataAccessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ContextError Context { get; }

        public string TokenError { get;  }
    }
}
