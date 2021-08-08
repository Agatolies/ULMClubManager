using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
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
            return $"{Availability}";
        }
    }
}
