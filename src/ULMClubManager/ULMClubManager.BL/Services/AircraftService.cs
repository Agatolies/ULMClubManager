using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public class AircraftService
    {
        public static List<Aircraft> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Aircrafts.ReadAll().ToList();
            }
        }

        public static List<AircraftCategory> ReadAllCategories()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.AircraftCategories.ReadAll().ToList();
            }
        }

        public static List<Runway> ReadAllRunways()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Runways.ReadAll().ToList();
            }
        }

        public static List<AircraftCategory> ReadAllAvailableCategories()
        {
            return AircraftService
                .ReadAllCategories()
                .Where(category => category.ID.Value < 4)
                .ToList();
        }
    }
}
