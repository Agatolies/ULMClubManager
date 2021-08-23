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
