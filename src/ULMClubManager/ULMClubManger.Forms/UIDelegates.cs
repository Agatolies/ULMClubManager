using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DTO;

namespace ULMClubManger.Forms
{
    // Délégués pour l'ajout, la modification et la suppression d'un membre
    public delegate void delSelectMember(int i);

    public delegate void delMemberCreating();
    public delegate void delMemberUpdating();
    public delegate void delMemberCanceling();

    public delegate void delMemberCreated();
    public delegate void delMemberUpdated();
    public delegate void delMemberCanceled();

    // Délégués pour l'ajout, la modification et la suppression d'une réservation par membre
    public delegate void delSelectBooking(DetailedBooking booking);
    public delegate void delUpdatePropertyEnabledOfDgvBookingByMember(bool enabled);

    public delegate void delBookingForMemberCreating();
    public delegate void delBookingForMemberUpdating();
    public delegate void delBookingForMemberCanceling();

    public delegate void delBookingForMemberCreated();
    public delegate void delBookingForMemberUpdated();
    public delegate void delBookingForMemberCanceled();

    // Délégués pour l'ajout, la modification et la suppression d'une réservation par ULM
    public delegate void delSelectAircraft(DetailedBooking booking);
    public delegate void delUpdatePropertyEnabledOfDgvBookingByAircraft(bool enabled);

    public delegate void delBookingForAircraftCreating();
    public delegate void delBookingForAircraftUpdating();
    public delegate void delBookingForAircraftCanceling();

    public delegate void delBookingForAircraftCreated();
    public delegate void delBookingForAircraftUpdated();
    public delegate void delBookingForAircraftCanceled();

    // Délégués pour le rafraichissement des vues
    //public delegate
}
