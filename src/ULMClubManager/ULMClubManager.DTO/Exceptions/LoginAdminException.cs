using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LoginAdminException : BusinessException
    {
        public LoginAdminException() 
            : base(ContextError.MBR, "ERR_ADMIN")
        {
        }
    }
}
