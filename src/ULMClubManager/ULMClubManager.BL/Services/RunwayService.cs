using System.Collections.Generic;
using System.Linq;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class RunwayService
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
