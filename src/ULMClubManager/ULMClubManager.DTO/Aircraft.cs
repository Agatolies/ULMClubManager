using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Aircraft : IDomainModel
    {
        public Aircraft(int? id, string registration, string type, int typeID)
        {
            ID = id;
            Registration = registration;
            Type = type;
            TypeID = typeID;
        }

        public Aircraft(string registration, string type, int typeID)
            : this(null, registration, type, typeID)
        {
        }

        public int? ID { get; }
        public string Registration { get; set; }
        public string Type { get; set; }
        public int TypeID { get; set; }

        public override string ToString()
        {
            return $"ULM {Registration} de type {Type} {TypeID}";
        }
    }
}
