using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class InvalidAicraftIDException : BusinessException
    {
        public InvalidAicraftIDException()
            : base(ContextError.RES, "BS_AER_ID")
        {
        }
    }
}
