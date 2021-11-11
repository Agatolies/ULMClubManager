namespace ULMClubManager.DTO;

/// <summary>
/// Enumération du type de membre
/// </summary>
public enum MemberTypeKey { Member, Pilot, Supporter }

/// <summary>
/// Représente un type de membre (Pilote ou Sympathisant)
/// </summary>
public class MemberType
{
    public MemberType(MemberTypeKey key, string description)
    {
        Key = key;
        Description = description;
    }

    public MemberTypeKey Key { get; }
    public string Description { get; }

    public static List<MemberType> GetMemberTypes()
    {
        return new List<MemberType>
        {
            new MemberType(MemberTypeKey.Member, "Membre"),
            new MemberType(MemberTypeKey.Pilot, "Pilote"),
            new MemberType(MemberTypeKey.Supporter, "Sympathisant")
        };
    }

}