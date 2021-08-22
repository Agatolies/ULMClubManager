using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DTO
{
    public class Qualification
    {
        public Qualification(
            bool type1, bool type2, bool type3,
            bool type4, bool type5, bool type6)
        {
            Type1 = type1;
            Type2 = type2;
            Type3 = type3;
            Type4 = type4;
            Type5 = type5;
            Type6 = type6;
        }

        public bool Type1 { get; set; }
        public bool Type2 { get; set; }
        public bool Type3 { get; set; }
        public bool Type4 { get; set; }
        public bool Type5 { get; set; }
        public bool Type6 { get; set; }
    }
}
