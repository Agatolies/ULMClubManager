using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidEmailAddressException : BusinessException
    {
        public InvalidEmailAddressException()
            : base(ContextError.MBR, "BS_MBR_EMAIL")
        {
        }
    }
}
