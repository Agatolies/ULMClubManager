using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers;

public class BookingMapper : GenericMapper<ResDBRow, Booking>
{
    public override Booking From(ResDBRow res)
    {
        return new Booking(
            res.RES_ID, res.RES_DTE, res.RES_HEU_DEB, res.RES_HEU_FIN,
            res.ANN_MOTIF, res.ANN_DTE, res.ANN_HEU, res.MBR_FK_ID,
            res.AER_FK_ID, res.PIST_FK_ID);
    }

    public override ResDBRow To(Booking res)
    {
        ResDBRow result = new ResDBRow();

        if (res.ID.HasValue)
            result.RES_ID = res.ID.Value;

        result.RES_DTE = res.Date;
        result.RES_HEU_DEB = res.StartHour;
        result.RES_HEU_FIN = res.EndHour;
        result.ANN_MOTIF = res.CancellationReason;
        result.ANN_DTE = res.CancellationDate;
        result.ANN_HEU = res.CancellationHour;
        result.MBR_FK_ID = res.MemberID;
        result.AER_FK_ID = res.AircraftID;
        result.PIST_FK_ID = res.RunwayID;

        return result;
    }
}