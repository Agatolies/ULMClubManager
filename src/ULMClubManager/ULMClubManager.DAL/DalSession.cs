using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DAL.Repositories;

namespace ULMClubManager.DAL
{
    public class DalSession : IDisposable
    {
        private IDbConnection _connection;
        private IUnitOfWork _unitOfWork;

        public DalSession()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _unitOfWork = new UnitOfWork(_connection);

            LocalityMapper localityMapper = new LocalityMapper();
            AircraftMapper aircraftMapper = new AircraftMapper();

            Localities = new LocalityRepository(_unitOfWork, localityMapper);
            Aircrafts = new AircraftRepository(_unitOfWork, aircraftMapper);
        }

        public IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }

        public LocalityRepository Localities { get; }
        public AircraftRepository Aircrafts { get; }

        public void Dispose()
        {
            _unitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
