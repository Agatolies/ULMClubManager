using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    // Nécessaire pour faire fonctionner CloneHelper
    [Serializable]
    public class Aircraft : IDomainModel
    {
        public Aircraft(int? id, string registration, string type, int typeID)
        {
            ID = id;
            Registration = registration;
            Type = type;
            CategoryID = typeID;
        }

        public Aircraft(string registration, string type, int typeID)
            : this(null, registration, type, typeID)
        {
        }

        public int? ID { get; }
        public string Registration { get; set; }
        public string Type { get; set; }
        public int CategoryID { get; set; }

        public override string ToString()
        {
            return $"ULM {Registration}  de classe {CategoryID}";
        }
    }
}
