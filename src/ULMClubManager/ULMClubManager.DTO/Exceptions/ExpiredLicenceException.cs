using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class ExpiredLicenceException : BusinessException
    {
        public ExpiredLicenceException()
            : base(ContextError.RES, "BS_RES_LIC")
        {
        }
    }
}
