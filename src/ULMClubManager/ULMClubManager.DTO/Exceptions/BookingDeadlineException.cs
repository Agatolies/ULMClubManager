using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class BookingDeadlineException : BusinessException

    {
        public BookingDeadlineException()
            : base(ContextError.RES, "BS_RES_DEADLINE")
        {

        }
    }
}
