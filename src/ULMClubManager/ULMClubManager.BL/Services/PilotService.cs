using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class PilotService
    {
        public static Pilot CreateOne(Pilot pilot)
        {
            using (DalSession dalSession = new DalSession())
            {
                //Pilot newPil = new Pilot(
                //    "713673960028620",
                //    new DateTime(2021, 07, 03),
                //    new DateTime(2024, 07, 01),
                //    "BE",
                //    "Malek",
                //    "Rami",
                //    "M",
                //    new DateTime(1981, 05, 12),
                //    new DateTime(2021,07,01),
                //    "Rue de la Reine",
                //    null,
                //    null,
                //    "91",
                //    null,
                //    "0478525232",
                //    "malek.rami@gmail.com",
                //    false,
                //    "ramimi",
                //    "12198105",
                //    4);

                return dalSession.Pilots.CreateOne(pilot);
            }
        }

        public static List<Pilot> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Pilots.ReadAll().ToList();
            }
        }

        public static List<Pilot> ReadAllByNameBegin(string filterName)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Pilots.ReadAllByNameBegin(filterName).ToList();
            }
        }

        public static Pilot ReadOne(int id)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Pilots.ReadOne(id);
            }
        }

        public static void UpdateOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Pilot rami = dalSession.Pilots.ReadOne(23);
                rami.FirstName = "Ramoudamour";
                dalSession.Pilots.UpdateOne(rami);
            }
        }
    }
}
