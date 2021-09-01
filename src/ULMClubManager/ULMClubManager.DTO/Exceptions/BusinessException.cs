using System;
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

        public BusinessException()
        {
        }

        public BusinessException(string message)
            : base(message)
        {
        }

        public BusinessException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ContextError Context { get; }

        public string TokenError { get;  }
    }
}
