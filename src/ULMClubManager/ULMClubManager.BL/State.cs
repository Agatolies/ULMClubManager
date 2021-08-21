using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.BL
{
    public static class State
    {
        public static IMember User { get; internal set; }
        public static bool IsAdmin => User.Administrator;
    }
}
