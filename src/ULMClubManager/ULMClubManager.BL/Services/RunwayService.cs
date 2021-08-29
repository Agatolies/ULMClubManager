using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public class RunwayService
    {
        public static List<Runway> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Runways.ReadAll().ToList();
            }
        }

        public static bool IsAvailable()
        {

            return false;
        }
    }
}
