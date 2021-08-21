using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LoginException : DataAccessException
    {
        public LoginException() 
            : base(ContextError.MBR, "ERR_LOGIN")
        {

        }
    }
}
