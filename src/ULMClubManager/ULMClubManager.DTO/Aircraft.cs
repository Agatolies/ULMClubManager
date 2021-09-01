using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    // Nécessaire pour faire fonctionner CloneHelper
    [Serializable]
    public class Aircraft : IDomainModel
    {
        public Aircraft(int? id, string registration, int typeID)
        {
            ID = id;
            Registration = registration;
            CategoryID = typeID;
        }

        public Aircraft(string registration, int typeID)
            : this(null, registration, typeID)
        {
        }

        public int? ID { get; }
        public string Registration { get; set; }
        public int CategoryID { get; set; }

        public override string ToString()
        {
            return $"ULM {Registration}  de classe {CategoryID}";
        }
    }
}
