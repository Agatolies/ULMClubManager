using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class BookingService
    {
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
                 dalSession.Bookings.DeleteOne(bookingID);
            }
        }

        public static void CreateOne(Booking booking)
        {
            using (DalSession dalSession = new DalSession())
            {
                dalSession.Bookings.CreateOne(booking);
            }
        }
    }
}
