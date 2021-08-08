using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
    public class Supporter : IDomainModel
    {
        public Supporter(int? memberID)
        {
            ID = memberID;
        }
        public int? ID { get; }

        public override string ToString()
        {
            return $"{ID}";
        }
    }
}
