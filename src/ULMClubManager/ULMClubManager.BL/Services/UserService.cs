using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.BL.Services
{
    public static class UserService
    {
        public static IMember User { get; set; }

        public static bool Login(string userName, string password)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.Match(userName, password);
            }
        }
    }
}
