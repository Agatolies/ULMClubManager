using System.Text.RegularExpressions;
using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL.Services
{
    public static class MemberService
    {
        // MEMBER

        public static List<Member> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.ReadAll().ToList();
            }
        }

        public static List<Member> ReadAllPilots()
        {
            return ReadAll()
                .Where(member => member.IsPilot)
                .ToList();
        }

        public static Member ReadOne(int id)
        {
            using (DalSession dalSession = new DalSession())
            {
                Member newMember = new Member();

                try
                {
                    dalSession.UnitOfWork.Begin();
                    newMember = dalSession.Members.ReadOne(id);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }

                return newMember;
            }
        }

        public static Member CreateOne(Member member)
        {
            ValidateMember(member);

            using (DalSession dalSession = new DalSession())
            {
                Member newMember = new Member();

                try
                {
                    dalSession.UnitOfWork.Begin();
                    newMember = dalSession.Members.CreateOne(member);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }

                return newMember;
            }
        }

        public static void UpdateOne(Member member)
        {
            ValidateMember(member);

            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();

                    int memberID = member.ID.Value;
                    Member oldMember = dalSession.Members.ReadOne(memberID);

                    if (oldMember.QualificationType1 && !member.QualificationType1)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 1);

                    if (oldMember.QualificationType2 && !member.QualificationType2)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 2);

                    if (oldMember.QualificationType3 && !member.QualificationType3)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 3);

                    if (oldMember.QualificationType4 && !member.QualificationType4)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 4);

                    if (oldMember.QualificationType5 && !member.QualificationType5)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 5);

                    if (oldMember.QualificationType6 && !member.QualificationType6)
                        DeleteBookingRelatedToMemberQualification(dalSession, memberID, 6);

                    if (oldMember.LicenceExpirationDate > member.LicenceExpirationDate)
                        DeleteBookingRelatedToMemberLicenceExpirationDate(dalSession, memberID, member.LicenceExpirationDate.Value);

                    dalSession.Members.UpdateOne(member);

                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        public static void CreateBooking(Booking booking)
        {
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

        private static void ValidateMember(Member member)
        {
            if (member.RegistrationDate == DateTime.MinValue)
                member.RegistrationDate = DateTime.Today;

            if (member.FirstName is null)
                throw new Exception("Le prénom ne peut pas être null.");

            if (member.FirstName.Length < 3)
                throw new FirstNameTooShortException();

            Regex regEmail = new Regex(
                @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
                RegexOptions.IgnoreCase);

            if (!regEmail.IsMatch(member.EmailAddress))
                throw new InvalidEmailAddressException();

            if (member.IsPilot)
            {
                if (member.LicenceCountry.Length != 2)
                    throw new InvalidCountryCodeException();

                bool hasQualification = (
                    member.QualificationType1
                    || member.QualificationType2
                    || member.QualificationType3
                    || member.QualificationType4
                    || member.QualificationType5
                    || member.QualificationType6);

                //bool hasLicence = 

                bool hasLicenceInfo =
                    member.LicenceNumber != null
                    || member.LicenceObtentionDate != null
                    || member.LicenceExpirationDate != null
                    || member.LicenceCountry != null;

                if (hasLicenceInfo && !hasQualification)
                    throw new LicenceWithoutQualificationsException();

                if (!hasLicenceInfo && hasQualification)
                    throw new QualificationWithoutLicenceException();
            }
        }

        // BOOKING

        public static List<Booking> ReadAllBooking()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAll().ToList();
            }
        }

        public static List<Booking> ReadAllBookingInFuture()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAllInFuture().ToList();
            }
        }

        public static Booking ReadOneBooking(int bookingID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadOne(bookingID);
            }
        }

        public static void UpdateOneBooking()
        {
            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();

                    Booking booking = dalSession.Bookings.ReadOne(29);
                    booking.AircraftID = 3;
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

        public static void DeleteOne(int memberID)
        {
            using (DalSession dalSession = new DalSession())
            {
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Members.DeleteOne(memberID);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        // SUBSCRIPTION

        public static List<Subscription> ReadAllSubscription(int memberID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Subscriptions.ReadAllByMemberID(memberID);
            }
        }

        public static string GetSubscriptionStatus(int memberID)
        {
            return GetLastSubscription(memberID).Description;
        }

        public static Subscription GetLastSubscription(int memberID)
        {
            return ReadAllSubscription(memberID)
                .OrderByDescending(subscription => subscription.TimePeriod)
                .FirstOrDefault();
        }

        public static bool IsInOrderOfPaiement(int memberID)
        {
            Subscription lastSubscription = GetLastSubscription(memberID);
            return lastSubscription.IsPaid && lastSubscription.IsForCurrentYear;
        }

        private static void DeleteBookingRelatedToMemberQualification(DalSession dalSession, int memberID, int categoryID)
        {
            List<Booking> bookingInFuture = ReadAllFutureBookingsByPilotID(memberID, dalSession);

            foreach (Booking b in bookingInFuture)
            {
                Aircraft aircraft = dalSession.Aircrafts.ReadOne(b.AircraftID);

                if (aircraft.CategoryID == categoryID)
                    dalSession.Cancellations.CreateOneCancellation(b.ID.Value, "Licence supprimée.");
            }
        }

        private static void DeleteBookingRelatedToMemberLicenceExpirationDate(DalSession dalSession, int memberID, DateTime newExpirationDate)
        {
            List<Booking> bookingInFuture = ReadAllFutureBookingsByPilotID(memberID, dalSession);

            foreach (Booking b in bookingInFuture)
            {
                // Supprimer toutes les RES dont la date est supérieure à la nouvelle date de fin de la LIC
                if (b.Date > newExpirationDate)
                    dalSession.Cancellations.CreateOneCancellation(b.ID.Value, "Modification de la date d'expiration de la licence.");
            }

        }

        private static List<Booking> ReadAllFutureBookingsByPilotID(int memberID, DalSession dalSession)
        {
            return dalSession.Bookings
                // celles d'un pilote
                .ReadAllByPilotID(memberID)
                // qui sont dans le futur
                .Where(b => b.Date > DateTime.Now)
                .ToList();
        }
    }
}
