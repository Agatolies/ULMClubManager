using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL.Services
{
    public static class BookingService
    {
        public static List<DetailedBooking> ReadAllFutureBooking()
        {
            using (DalSession dalSession = new DalSession())
            {
                List<Booking> bookings = dalSession.Bookings.ReadAllInFuture()
                    .Where(b => string.IsNullOrEmpty(b.CancellationReason))
                    .ToList();

                List<DetailedBooking> detailedBookings = GetRelatedData(dalSession, bookings);

                return detailedBookings;
            }
        }

        public static List<DetailedBooking> ReadAllBookingByPilotID(int pilotID)
        {
            using (DalSession dalSession = new DalSession())
            {
                List<Booking> bookings = dalSession.Bookings.ReadAllByPilotID(pilotID).ToList();
                List<DetailedBooking> detailedBookings = GetRelatedData(dalSession, bookings);

                return detailedBookings;
            }
        }

        public static List<DetailedBooking> ReadAllBookingByAircraftID(int aircraftID)
        {
            using (DalSession dalSession = new DalSession())
            {
                List<Booking> bookings = dalSession.Bookings.ReadAllByAircraftID(aircraftID).ToList();
                List<DetailedBooking> detailedBookings = GetRelatedData(dalSession, bookings);

                return detailedBookings;
            }
        }

        public static List<DetailedBooking> ReadAllBookingByRunwayID(int runwayID)
        {
            using (DalSession dalSession = new DalSession())
            {
                List<Booking> bookings = dalSession.Bookings.ReadAllByRunwayID(runwayID).ToList();
                List<DetailedBooking> detailedBookings = GetRelatedData(dalSession, bookings);

                return detailedBookings;
            }
        }

        private static List<DetailedBooking> GetRelatedData(DalSession dalSession, List<Booking> bookingList)
        {
            List<DetailedBooking> detailedBookings = new List<DetailedBooking>();

            foreach (var booking in bookingList)
            {
                Aircraft aircraft = dalSession.Aircrafts.ReadOne(booking.AircraftID);
                Runway runway = dalSession.Runways.ReadOne(booking.RunwayID);
                Member pilot = dalSession.Members.ReadOne(booking.MemberID);

                DetailedBooking detailedBooking = new DetailedBooking(booking, aircraft, runway, pilot);

                detailedBookings.Add(detailedBooking);
            }

            return detailedBookings;
        }

        public static void DeleteOneBooking(int bookingID)
        {
            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Bookings.DeleteOne(bookingID);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        public static void CreateOne(Booking booking)
        {
            ValidateBooking(booking);

            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Bookings.CreateOne(booking);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        public static void UpdateOne(Booking booking)
        {
            ValidateBooking(booking);

            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Bookings.UpdateOne(booking);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        public static void ValidateBooking(Booking booking)
        {
            // VERIFICATION DATE LIMITE AVANT MARS DE L'ANNEE SUIVANTE
            int nextYear = booking.Date.AddYears(1).Year;
            DateTime bookingDeadline = new DateTime(nextYear, 3, 1);

            if (booking.Date >= bookingDeadline)
                throw new BookingDeadlineException();

            // VERIFICATION EN ORDRE DE PAIEMENT
            if (!MemberService.IsInOrderOfPaiement(booking.MemberID))
                throw new InvalidSubscriptionForBookingException();

            // VERIFICATION POUR UN PILOTE, UNE PISTE ET UN AERONEF
            using (DalSession dalSession = new DalSession())
            {
                // Récupèration de tous les bookings existants non annulés pour la date souhaitée
                List<Booking> allBookings = dalSession.Bookings.ReadAll();

                List<Booking> existingBookingsToCheck = allBookings
                    .Where(b => string.IsNullOrEmpty(b.CancellationReason)
                                && b.Date.Year == booking.Date.Year
                                && b.Date.Month == booking.Date.Month
                                && b.Date.Day == booking.Date.Day)
                    .ToList();

                ValidatePilotAvailability(booking, existingBookingsToCheck);
                ValidateRunwayAvailability(booking, existingBookingsToCheck);
                ValidateAircraftAvailability(booking, existingBookingsToCheck);
            }

            // VERIFICATION LICENCE ET QUALIFICATIONS
            Member pilot = MemberService.ReadOne(booking.MemberID);
            Aircraft aircraft = AircraftService.ReadOne(booking.AircraftID);

            if (!pilot.HasQualification(aircraft.CategoryID))
                throw new IncorrectQualificationException();

            if (!pilot.HasValidLicence(booking.Date))
                throw new ExpiredLicenceException();

            if (WithdrawalService.HasWithdrawalByDate(booking.MemberID, booking.Date))
                throw new LicenceWithdrawalException();
        }

        // PILOT INFO

        private static void ValidatePilotAvailability(Booking booking, List<Booking> existingBookingsToCheck)
        {
            // Sélection de celles qui concernent le pilote qu'on souhaite...
            List<Booking> bookingsForPilot = existingBookingsToCheck
                .Where(b => b.MemberID== booking.MemberID)
                .ToList();

            // ...Pour lesquels on vérifie les heures
            foreach (Booking b in bookingsForPilot)
            {
                if (IsOverlapse(booking, b))
                {
                    throw new UnavailablePilotException();
                }
            }
        }

        private static void ValidateRunwayAvailability(Booking booking, List<Booking> existingBookingsToCheck)
        {
            // Sélection de celles qui concernent la piste qu'on souhaite...
            List<Booking> bookingsForRunway = existingBookingsToCheck
                .Where(b => b.RunwayID == booking.RunwayID)
                .ToList();

            // ...Pour lesquels on vérifie les heures
            foreach (Booking b in bookingsForRunway)
            {
                if (IsOverlapse(booking, b))
                {
                    throw new UnavailableRunwayException();
                }
            }
        }

        private static void ValidateAircraftAvailability(Booking booking, List<Booking> existingBookingsToCheck)
        {
            // Sélection de celles qui concernent l'aeronef qu'on souhaite...
            List<Booking> bookingsForAircraft = existingBookingsToCheck
                .Where(b => b.AircraftID == booking.AircraftID)
                .ToList();

            // ...Pour lesquels on vérifie les heures
            foreach (Booking b in bookingsForAircraft)
            {
                if (IsOverlapse(booking, b))
                {
                    throw new UnavailableAircraftException();
                }
            }
        }

        private static bool IsOverlapse(Booking newBooking, Booking existingBooking)
        {
            bool isOverlapse = newBooking.StartHour < existingBooking.EndHour
                ? existingBooking.StartHour < newBooking.EndHour.Add(TimeSpan.FromMinutes(15))
                : newBooking.StartHour < existingBooking.EndHour.Add(TimeSpan.FromMinutes(15));

            return isOverlapse;
        }
    }
}
