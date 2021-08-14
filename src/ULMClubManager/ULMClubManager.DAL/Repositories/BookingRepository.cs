﻿using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;
using Dapper;
using System.Data;
using System.Collections.Generic;

namespace ULMClubManager.DAL.Repositories
{
    public class BookingRepository : GenericRepository<ResDBRow, int, Booking>
    {
        public BookingRepository(IUnitOfWork unitOfWork, BookingMapper mapper)
            : base(unitOfWork, "RES", mapper)
        {
        }

        public override Booking CreateOne(Booking domainModel)
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
                commandType: CommandType.StoredProcedure);

            return ReadLast();
        }

        public override List<Booking> ReadAll()
        {
            IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
                "sp_select_RES");
            return _mapper.From(models);
        }

        public List<Booking> ReadAllByPilotID(int pilotID)
        {
            IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
                "sp_select_RES_BY_PIL_ID",
                param: new { PIL_ID = pilotID },
                commandType: CommandType.StoredProcedure);

            return _mapper.From(models);
        }

        public List<Booking> ReadAllByAircraftID(int aircraftID)
        {
            IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
                "sp_select_RES_BY_AER_ID",
                param: new { AER_ID = aircraftID },
                commandType: CommandType.StoredProcedure);

            return _mapper.From(models);
        }

        public List<Booking> ReadAllByRunwayID(int runwayID)
        {
            IEnumerable<ResDBRow> models = _unitOfWork.Connection.Query<ResDBRow>(
                "sp_select_RES_BY_PIST_ID",
                param: new { PIST_ID = runwayID },
                commandType: CommandType.StoredProcedure);

            return _mapper.From(models);
        }

        public override Booking ReadOne(int id)
        {
            ResDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<ResDBRow>(
                "sp_select_RES_BY_ID",
                param: new { RES_ID = id },
                commandType: CommandType.StoredProcedure);

            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public override Booking ReadLast()
        {
            ResDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<ResDBRow>(
                "sp_select_RES_LAST");
            return _mapper.From(result);
        }

        public override void UpdateOne(Booking domainModel)
        {
            ResDBRow model = _mapper.To(domainModel);

            _unitOfWork.Connection.Execute(
                "sp_update_RES",
                param: model,
                commandType: CommandType.StoredProcedure);
        }
    }
}
