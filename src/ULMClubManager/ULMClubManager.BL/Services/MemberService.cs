using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL.Services
{
    public static class MemberService
    {
        public static List<Member> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.ReadAll().ToList();
            }
        }

        public static Member ReadOne(int id)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.ReadOne(id);
            }
        }

        public static Member CreateOne(Member member)
        {
            ValidateMember(member);

            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.CreateOne(member);
            }
        }

        public static void UpdateOne(Member member)
        {
            ValidateMember(member);

            using (DalSession dalSession = new DalSession())
            {
                dalSession.Members.UpdateOne(member);
            }
        }

        public static void CreateBooking(Booking booking)
        {
            using (DalSession dalSession = new DalSession())
            {
                dalSession.Bookings.CreateOne(booking);
            }
        }

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
                Booking booking = dalSession.Bookings.ReadOne(29);
                booking.AircraftID = 3;
                dalSession.Bookings.UpdateOne(booking);
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
                catch (Exception ex)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        private static void ValidateMember(Member member)
        {
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

                bool hasNoQualification =
                    !member.QualificationType1
                    && !member.QualificationType2
                    && !member.QualificationType3
                    && !member.QualificationType4
                    && !member.QualificationType5
                    && !member.QualificationType6;

                bool hasLicence = member.LicenceNumber != null;

                if (hasLicence && hasNoQualification)
                    throw new LicenceWithoutQualificationsException();
            }
        }
    }
}
