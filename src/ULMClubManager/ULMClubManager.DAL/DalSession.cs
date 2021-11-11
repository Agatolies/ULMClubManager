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
    public sealed class DalSession : IDisposable
    {
        private static IDbConnection CreateConnection()
        {
            const string connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";
            return new SqlConnection(connectionString);
        }

        private readonly IDbConnection _connection;

        private AircraftRepository? _aircrafts;
        private BookingRepository? _bookings;
        private AircraftCategoryRepository? _categories;
        private LocalityRepository? _localities;
        private RunwayRepository? _runways;
        private SubscriptionRepository? _subscriptions;
        private UnavailabilityRepository? _unavailabilities;
        private WithdrawalRepository? _withdrawals;
        private MemberRepository? _members;
        private CancellationRepository? _cancellations;

        public DalSession()
        {
            _connection = CreateConnection();
            _connection.Open();

            UnitOfWork = new UnitOfWork(_connection);
        }

        public IUnitOfWork UnitOfWork { get; }

        public AircraftRepository Aircrafts => 
            _aircrafts ??= new AircraftRepository(UnitOfWork, new AircraftMapper());

        public BookingRepository Bookings =>
            _bookings ??= new BookingRepository(UnitOfWork);

        public AircraftCategoryRepository AircraftCategories =>
            _categories ??= new AircraftCategoryRepository(UnitOfWork, new CategoryMapper());

        public LocalityRepository Localities =>
            _localities ??= new LocalityRepository(UnitOfWork, new LocalityMapper());

        public RunwayRepository Runways =>
            _runways ??= new RunwayRepository(UnitOfWork, new RunwayMapper());

        public SubscriptionRepository Subscriptions =>
            _subscriptions ??= new SubscriptionRepository(UnitOfWork, new SubscriptionMapper());

        public UnavailabilityRepository Unavailabilities =>
            _unavailabilities ??= new UnavailabilityRepository(UnitOfWork, new UnavailabilityMapper());

        public WithdrawalRepository Withdrawals =>
            _withdrawals ??= new WithdrawalRepository(UnitOfWork, new WithdrawalMapper());

        public MemberRepository Members =>
            _members ??= new MemberRepository(UnitOfWork);

        public CancellationRepository Cancellations =>
            _cancellations ??= new CancellationRepository(UnitOfWork);

        public void Dispose()
        {
            _aircrafts = null;
            _bookings = null;
            _categories = null;
            _localities = null;
            _members = null;
            _runways = null;
            _subscriptions = null;
            _unavailabilities = null;
            _withdrawals = null;

            UnitOfWork.Dispose();
            _connection.Dispose();
        }
    }
}
