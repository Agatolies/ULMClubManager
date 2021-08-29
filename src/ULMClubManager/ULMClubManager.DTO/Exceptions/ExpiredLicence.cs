using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class ExpiredLicence : BusinessException
    {
        public ExpiredLicence()
            : base(ContextError.RES, "BS_RES_LIC")
        {
        }
    }
}
