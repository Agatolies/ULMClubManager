using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DTO
{
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

            for (int i = 8; i <= 20; i++)
            {
                string timeSlot = $"{i}:00";
                result.Add(TimeSpan.Parse(timeSlot));
            }

            return result;
        }
    }
}
