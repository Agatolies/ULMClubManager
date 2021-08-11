using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Locality : IDomainModel
    {
        public Locality(int? id, string zipCode, string name)
        {
            ID = id;
            ZipCode = zipCode;
            Name = name;
        }

        public Locality(string zipCode, string name)
            : this(null, zipCode, name)
        {
        }

        public int? ID { get; }
        public string ZipCode { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{ZipCode} {Name}";
        }
    }
}
