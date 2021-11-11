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

        public static void CreateOneCancellation(int bookingID, string reason)
        {
            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Cancellations.CreateOneCancellation(bookingID, reason);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }
    }
}
