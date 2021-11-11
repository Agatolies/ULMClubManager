using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;
using Dapper;
using System.Data;

namespace ULMClubManager.DAL.Repositories;

public class BookingRepository
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly BookingMapper _bookingMapper;

    public BookingRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _bookingMapper = new BookingMapper();
    }

    // Bookings

    public List<Booking> ReadAll()
    {
        IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
            "sp_select_RES",
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(models);
    }

    public List<Booking> ReadAllByPilotID(int pilotID)
    {
        IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
            "sp_select_RES_BY_MBR_ID",
            param: new { PIL_ID = pilotID },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(models);
    }

    public List<Booking> ReadAllByAircraftID(int aircraftID)
    {
        IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
            "sp_select_RES_BY_AER_ID",
            param: new { AER_ID = aircraftID },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(models);
    }

    public List<Booking> ReadAllByRunwayID(int runwayID)
    {
        IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
            "sp_select_RES_BY_PIST_ID",
            param: new { PIST_ID = runwayID },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(models);
    }

    public List<Booking> ReadAllInFuture()
    {
        IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
            "sp_select_RES_IN_FUTURE",
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(models);
    }

    public Booking ReadOne(int id)
    {
        ResDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<ResDBRow>(
            "sp_select_RES_BY_ID",
            param: new { RES_ID = id },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        if (result == null)
            throw new KeyNotFoundException($"La table RES avec l'id [{id}] n'existe pas.");

        return _bookingMapper.From(result);
    }

    public Booking ReadLast()
    {
        ResDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<ResDBRow>(
            "sp_select_RES_LAST",
            transaction: _unitOfWork.Transaction);

        return _bookingMapper.From(result);
    }

    public Booking CreateOne(Booking domainModel)
    {
        // L'utilisation du mapper n'est pas souhaitée ici.
        // Si nous utilisions le PilotMapper, nous aurions un paramètre
        // "MBR_ID" en trop pour pouvoir executer la procédure stockée.

        _unitOfWork.Connection.Execute(
            "sp_insert_RES",
            param: new
            {
                RES_DTE = domainModel.Date,
                RES_HEU_DEB = domainModel.StartHour,
                RES_HEU_FIN = domainModel.EndHour,
                MBR_FK_ID = domainModel.MemberID,
                AER_FK_ID = domainModel.AircraftID,
                PIST_FK_ID = domainModel.RunwayID
            },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return ReadLast();
    }

    public void UpdateOne(Booking domainModel)
    {
        _unitOfWork.Connection.Execute(
            "sp_update_RES",
            param: new
            {
                RES_ID = domainModel.ID.Value,
                RES_DTE = domainModel.Date,
                RES_HEU_DEB = domainModel.StartHour,
                RES_HEU_FIN = domainModel.EndHour,
                MBR_FK_ID = domainModel.MemberID,
                AER_FK_ID = domainModel.AircraftID,
                PIST_FK_ID = domainModel.RunwayID
            },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);
    }

    public int DeleteOne(int bookingID)
    {
        int result = _unitOfWork.Connection.Execute(
            "sp_delete_RES_BY_RES_ID",
            param: new { RES_ID = bookingID },
            commandType: CommandType.StoredProcedure,
            transaction: _unitOfWork.Transaction);

        return result;
    }
}