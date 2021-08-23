using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DTO
{
    public enum MemberTypeKey { Member, Pilot, Supporter}

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
}
