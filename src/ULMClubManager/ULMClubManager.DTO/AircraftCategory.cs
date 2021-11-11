using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO;

/// <summary>
/// Représente une classe d'ULM
/// </summary>
public class AircraftCategory : IDomainModel
{
    public AircraftCategory(int? id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
    }

    public AircraftCategory(string name, string description)
        : this(null, name, description)
    {
    }

    public int? ID { get; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Classe {Name}";
    }
}