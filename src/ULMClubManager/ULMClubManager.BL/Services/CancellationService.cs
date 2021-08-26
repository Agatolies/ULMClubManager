using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class CancellationService
    {
        public static List<Cancellation> ReadAllCancellations()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Cancellations.ReadAllCancellations().ToList();
            }
        }

        public static List<Cancellation> ReadAllCancellationByPilotID(int pilotID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Cancellations.ReadAllCancellationsByPilotID(pilotID).ToList();
            }
        }

        public static List<Cancellation> ReadAllCancellationsByAircraftID(int aircraftID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Cancellations.ReadAllCancellationsByAircraftID(aircraftID).ToList();
            }
        }

        public static Cancellation CreateOneCancellation(Cancellation cancellation)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Cancellations.CreateOneCancellation(cancellation);
            }
        }
    }
}
