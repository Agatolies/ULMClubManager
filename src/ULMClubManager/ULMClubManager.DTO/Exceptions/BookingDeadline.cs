using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    public class BookingDeadline : BusinessException

    {
        public BookingDeadline()
            : base(ContextError.RES, "BS_RES_DEADLINE")
        {

        }
    }
}
