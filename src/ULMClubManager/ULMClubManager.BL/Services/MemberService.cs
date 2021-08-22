using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class MemberService
    {
        public static Member CreateOne(Member pilot)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Members.CreateOne(pilot);
            }
        }

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

        public static void UpdateOne(Member member)
        {
            using (DalSession dalSession = new DalSession())
            {
                dalSession.Members.UpdateOne(member);
            }
        }

        public static void CreateBooking()
        {
            using (DalSession dalSession = new DalSession())
            {
                Booking newbooking = new Booking(
                    new DateTime(2021, 9, 2), 
                    new TimeSpan(13, 0, 0), 
                    new TimeSpan(14, 30, 0), 
                    null,
                    null,
                    null,
                    23,
                    2,
                    2);

                dalSession.Bookings.CreateOne(newbooking);
            }
        }

        public static List<Booking> ReadAllBooking()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAll().ToList();
            }
        }

        public static List<Booking> ReadAllBookingByPilotID(int pilotID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAllByPilotID(pilotID).ToList();
            }
        }

        public static List<Booking> ReadAllBookingByAircraftID(int aircraftID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAllByAircraftID(aircraftID).ToList();
            }
        }

        public static List<Booking> ReadAllBookingByRunwayID(int runwayID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Bookings.ReadAllByRunwayID(runwayID).ToList();
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
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }
    }

   
}
