using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    /// <summary>
    /// Représente une piste
    /// </summary>
    public class Runway : IDomainModel
    {
        public Runway(int? id, bool availability)
        {
            ID = id;
            Availability = availability;
        }

        public Runway(bool availability)
            : this(null, availability)
        {
        }

        public int? ID { get; }
        public bool Availability { get; set; }

        public override string ToString()
        {
            return $"Piste {ID}";
        }
    }
}
