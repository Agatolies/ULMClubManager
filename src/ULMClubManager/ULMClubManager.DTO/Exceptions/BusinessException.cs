using System;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
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
