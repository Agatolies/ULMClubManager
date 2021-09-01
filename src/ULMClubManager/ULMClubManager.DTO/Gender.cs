using System.Collections.Generic;

namespace ULMClubManager.DTO
{
    public class Gender
    {
        public Gender(string key, string description)
        {
            Key = key;
            Description = description;
        }

        public string Key { get; }
        public string Description { get; }

        public static List<Gender> GetGenders()
        {
            return new List<Gender> 
            { 
                new Gender("F", "Femme"),
                new Gender("M", "Homme") 
            };
        }
    }
}
