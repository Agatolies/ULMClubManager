using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class FirstNameTooShortException : BusinessException
    {
        public FirstNameTooShortException()
            : base(ContextError.MBR, "BS_MBR_PRN")
        {
        }
    }
}
