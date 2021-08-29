using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class LicenceWithdrawalException : BusinessException
    {
        public LicenceWithdrawalException()
            : base(ContextError.RES, "BS_RES_RET")
        {
        }
    }
}
