namespace ULMClubManager.DTO
{
    /// <summary>
    /// Représente un créneau horaire pour une réservation
    /// </summary>
    public class TimeSlot
    {
        public TimeSlot(TimeSpan value)
        {
            Value = value;
        }

        public TimeSpan Value { get; }

        public static List<TimeSpan> GetTimeSlots()
        {
            List<TimeSpan> result = new List<TimeSpan>();

            List<string> minutes = new List<string> { "00", "15", "30", "45" };

            for (int i = 8; i <= 20; i++)
            {
                foreach (string min in minutes)
                {
                    string timeSlotHour = $"{i}:{min}";
                    result.Add(TimeSpan.Parse(timeSlotHour));
                }
            }

            return result;
        }
    }
}
