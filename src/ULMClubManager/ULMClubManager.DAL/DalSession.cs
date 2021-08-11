using System;
using System.Data;
using System.Data.SqlClient;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DAL.Repositories;

namespace ULMClubManager.DAL
{
    /// <summary>
    /// Responsable d'instancier la connexion à la DB et de fournir 
    /// un point d'accès unique à tous les Respositories de la DAL.
    /// </summary>
    public class DalSession : IDisposable
    {
        private IDbConnection _connection;
        private IUnitOfWork _unitOfWork;

        private AircraftRepository _aircrafts;
        private BookingRepository _bookings;
        private CancellationRepository _cancellations;
        private CategoryRepository _categories;
        private LocalityRepository _localities;
        private PilotRepository _pilots;
        private RunwayRepository _runways;
        private SubscriptionRepository _subscriptions;
        private SupporterRepository _supporters;
        private UnavailabilityRepository _unavailabilities;
        private WithdrawalRepository _withdrawals;

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

        public AircraftRepository Aircrafts 
        { 
            get
            {
                return _aircrafts ?? (_aircrafts = new AircraftRepository(_unitOfWork, new AircraftMapper()));

                // La ligne au-dessus est identique au code ci-dessous
                // if (_aircrafts == null)
                // {
                //     _aircrafts = new AircraftRepository(_unitOfWork, new AircraftMapper());
                // }
                // return _aircrafts;
            }
        }

        public BookingRepository Bookings
        {
            get
            {
                return _bookings ?? (_bookings = new BookingRepository(_unitOfWork, new BookingMapper()));
            }
        }

        public CancellationRepository Cancellations
        {
            get
            {
                return _cancellations ?? (_cancellations = new CancellationRepository(_unitOfWork, new CancellationMapper()));
            }
        }

        public CategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new CategoryRepository(_unitOfWork, new CategoryMapper()));
            }
        }

        public LocalityRepository Localities
        {
            get
            {
                return _localities ?? (_localities = new LocalityRepository(_unitOfWork, new LocalityMapper()));
            }
        }

        public PilotRepository Pilots
        {
            get
            {
                return _pilots ?? (_pilots = new PilotRepository(_unitOfWork, new PilotMapper()));
            }
        }

        public RunwayRepository Runways
        {
            get
            {
                return _runways ?? (_runways = new RunwayRepository(_unitOfWork, new RunwayMapper()));
            }
        }

        public SubscriptionRepository Subscriptions
        {
            get
            {
                return _subscriptions ?? (_subscriptions = new SubscriptionRepository(_unitOfWork, new SubscriptionMapper()));
            }
        }

        public SupporterRepository Supporters
        {
            get
            {
                return _supporters ?? (_supporters = new SupporterRepository(_unitOfWork, new SupporterMapper()));
            }
        }

        public UnavailabilityRepository Unavailabilities
        {
            get
            {
                return _unavailabilities ?? (_unavailabilities = new UnavailabilityRepository(_unitOfWork, new UnavailabilityMapper()));
            }
        }

        public WithdrawalRepository Withdrawals
        {
            get
            {
                return _withdrawals ?? (_withdrawals = new WithdrawalRepository(_unitOfWork, new WithdrawalMapper()));
            }
        }

        public void Dispose()
        {
            _aircrafts = null;
            _bookings = null;
            _cancellations = null;
            _categories = null;
            _localities = null;
            _pilots = null;
            _runways = null;
            _subscriptions = null;
            _supporters = null;
            _unavailabilities = null;
            _withdrawals = null;

            _unitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
