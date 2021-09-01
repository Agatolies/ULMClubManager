using ULMClubManager.DTO.Enums;

namespace ULMClubManager.DTO.Exceptions
{
    /// <summary>
    /// Représente une exception qui indique qu'une réservation
    /// ne peut pas être enregistrée après février de l'année suivante
    /// </summary>
    public class BookingDeadlineException : BusinessException

    {
        public BookingDeadlineException()
            : base(ContextError.RES, "BS_RES_DEADLINE")
        {

        }

        protected BookingDeadlineException(ContextError context, string tokenError)
            : base(context, tokenError)
        {
        }

        public BookingDeadlineException(string message)
            : base(message)
        {
        }

        public BookingDeadlineException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
