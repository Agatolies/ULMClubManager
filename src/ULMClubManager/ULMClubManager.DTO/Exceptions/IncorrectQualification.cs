using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class IncorrectQualification : BusinessException
    {
        public IncorrectQualification()
            : base(ContextError.RES, "BS_RES_QUAL")
        {
        }
    }
}
