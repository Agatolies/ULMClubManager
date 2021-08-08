using System;
using ULMClubManager.DAL.Abstractions;

namespace ULMClubManager.DAL.DomainModels
{
    public class Pilot : IDomainModel
    {
        public Pilot(int? memberID, string licenceNumber, DateTime obtentionDate, DateTime expirationDate, string country)
        {
            ID = memberID;
            LicenceNumber = licenceNumber;
            ObtentionDate = obtentionDate;
            ExpirationDate = expirationDate;
            Country = country;
        }

        public Pilot(string licenceNumber, DateTime obtentionDate, DateTime expirationDate, string country)
            : this(null, licenceNumber, obtentionDate, expirationDate, country)
        {
        }

        public int? ID { get; }
        public string LicenceNumber { get; set; }
        public DateTime ObtentionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Le numéro de licence {LicenceNumber} délivré dans le pays {Country}";
        }
    }
}
