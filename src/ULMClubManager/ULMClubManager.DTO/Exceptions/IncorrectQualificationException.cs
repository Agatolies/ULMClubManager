using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class IncorrectQualificationException : BusinessException
    {
        public IncorrectQualificationException()
            : base(ContextError.RES, "BS_RES_QUAL")
        {
        }
    }
}
