using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
    public class Category : IDomainModel
    {
        public Category(int? id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public Category(string name, string description)
            : this(null, name, description)
        {
        }

        public int? ID { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"L'ULM est de type {Name}";
        }
    }
}
