using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Repositories
{
    public class CancellationRepository 
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CancellationMapper _cancellationMapper;

        public CancellationRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _cancellationMapper = new CancellationMapper();
        }

        public  List<Cancellation> ReadAllCancellations()
        {
            IEnumerable<AnnDBRow> models = _unitOfWork.Connection.Query<AnnDBRow>(
                "sp_select_ANN",
                transaction: _unitOfWork.Transaction);

            return _cancellationMapper.From(models);
        }

        public List<Cancellation> ReadAllCancellationsByPilotID(int pilotID)
        {
            IEnumerable<AnnDBRow> models = _unitOfWork.Connection.Query<AnnDBRow>(
                "sp_select_ANN_BY_MBR_ID",
                param: new { MBR_ID = pilotID },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);

            return _cancellationMapper.From(models);
        }

        

        public List<Cancellation> ReadAllCancellationsByAircraftID(int aircraftID)
        {
            IEnumerable<AnnDBRow> models = _unitOfWork.Connection.Query<AnnDBRow>(
                "sp_select_ANN_BY_AER_ID",
                param: new { AER_ID = aircraftID },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);

            return _cancellationMapper.From(models);
        }

        private Cancellation ReadOneCancellation(int? id)
        {
            AnnDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<AnnDBRow>(
                "sp_select_ANN_BY_RES_ID",
                param: new { RES_ID = id },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);

            if (result == null)
                throw new KeyNotFoundException("Cette réservation  n'existe pas.");

            return _cancellationMapper.From(result);
        }

        public void CreateOneCancellation(int bookingID, string reason)
        {
            _unitOfWork.Connection.QueryFirstOrDefault<AnnDBRow>(
                "sp_insert_ANN",
                param: new
                {
                    RES_FK_ID = bookingID,
                    ANN_MOTIF = reason,
                },
                commandType: CommandType.StoredProcedure,
                transaction: _unitOfWork.Transaction);
        }

        

        //public Booking DeleteOneCancellation(int bookingID)
        //{
        //    _unitOfWork.Connection.QueryFirstOrDefault<ResDBRow>(
        //        "sp_delete_ANN",
        //        param: new { bookingID },
        //        commandType: CommandType.StoredProcedure,
        //        transaction: _unitOfWork.Transaction);

        //    return ReadOne(bookingID);
        //}
    }
}
