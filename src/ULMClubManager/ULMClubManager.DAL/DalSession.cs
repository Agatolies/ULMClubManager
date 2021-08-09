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
        private LocalityRepository _localities;
        private AircraftRepository _aircrafts;

        public DalSession()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";

            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _unitOfWork = new UnitOfWork(_connection);
        }

        public IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }

        public LocalityRepository Localities 
        { 
            get
            {
                if (_localities == null)
                {
                    LocalityMapper localityMapper = new LocalityMapper();
                    _localities = new LocalityRepository(_unitOfWork, localityMapper);
                }

                return _localities;
            }
        }
        public AircraftRepository Aircrafts 
        { 
            get
            {
                if (_aircrafts == null)
                {
                    AircraftMapper aircraftMapper = new AircraftMapper();
                    _aircrafts = new AircraftRepository(_unitOfWork, aircraftMapper);
                }

                return _aircrafts;
            }
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
