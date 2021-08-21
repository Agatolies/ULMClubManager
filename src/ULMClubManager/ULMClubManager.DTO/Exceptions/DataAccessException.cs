using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public abstract class DataAccessException : Exception
    {
        protected DataAccessException(ContextError context, string tokenError)
        {
            Context = context;
            TokenError = tokenError;
        }
        
        public ContextError Context { get; }

        public string TokenError { get;  }
    }
}
