using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.BL.Services
{
    public static class UserService
    {
        public static void Login(string userName, string password)
        {
            using (DalSession dalSession = new DalSession())
            {
                int memberID = dalSession.Members.Match(userName, password);

                try
                {
                    Pilot pilot = dalSession.Pilots.ReadOne(memberID);
                    State.User = pilot;
                    State.IsPilot = true;
                    State.IsSupporter = false;
                }
                catch (KeyNotFoundException)
                {
                    Supporter supporter = dalSession.Supporters.ReadOne(memberID);
                    State.User = supporter;
                    State.IsSupporter = true;
                    State.IsPilot = false;
                }
            }
        }
    }
}
