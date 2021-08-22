﻿using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Member : IDomainModel
    {
        public Member(int? id, string licenceNumber, DateTime licenceObtentionDate,
            DateTime licenceExpirationDate, string licenceCountry, 
            string lastName, string firstName, string sex, 
            DateTime dateOfBirth, DateTime registrationDate, string street, 
            string residenceName, string buildingNumber, string boxNumber, 
            string phoneNumber, string cellphoneNumber, string emailAddress, 
            bool administrator, string userName, string userPWD, int localityID,
            bool qualificationType1, bool qualificationType2, bool qualificationType3,
            bool qualificationType4, bool qualificationType5, bool qualificationType6)
        {
            ID = id;
            LicenceNumber = licenceNumber;
            LicenceObtentionDate = licenceObtentionDate;
            LicenceExpirationDate = licenceExpirationDate;
            LicenceCountry = licenceCountry;
            LastName = lastName;
            FirstName = firstName;
            Sex = sex;
            DateOfBirth = dateOfBirth;
            RegistrationDate = registrationDate;
            Street = street;
            ResidenceName = residenceName;
            BuildingNumber = buildingNumber;
            BoxNumber = boxNumber;
            PhoneNumber = phoneNumber;
            CellphoneNumber = cellphoneNumber;
            EmailAddress = emailAddress;
            Administrator = administrator;
            UserName = userName;
            UserPWD = userPWD;
            LocalityID = localityID;
            QualificationType1 = qualificationType1;
            QualificationType2 = qualificationType2;
            QualificationType3 = qualificationType3;
            QualificationType4 = qualificationType4;
            QualificationType5 = qualificationType5;
            QualificationType6 = qualificationType6;
        }

        public Member(string licenceNumber, DateTime licenceObtentionDate,
            DateTime licenceExpirationDate, string licenceCountry, 
            string lastName, string firstName, string sex,
            DateTime dateOfBirth, DateTime registrationDate, string street,
            string residenceName, string buildingNumber, string boxNumber,
            string phoneNumber, string cellphoneNumber, string emailAddress,
            bool administrator, string userName, string userPWD, int localityID,
            bool qualificationType1, bool qualificationType2, bool qualificationType3,
            bool qualificationType4, bool qualificationType5, bool qualificationType6)
            : this(null, licenceNumber, licenceObtentionDate,
                licenceExpirationDate, licenceCountry, 
                lastName, firstName, sex, 
                dateOfBirth, registrationDate, street, 
                residenceName, buildingNumber, boxNumber,
                phoneNumber, cellphoneNumber, emailAddress,
                administrator, userName, userPWD, localityID, 
                qualificationType1, qualificationType2, qualificationType3,
                qualificationType4, qualificationType5, qualificationType6)
        {
        }

        public Member()
        {
        }

        public int? ID { get; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Street { get; set; }
        public string ResidenceName { get; set; }
        public string BuildingNumber { get; set; }
        public string BoxNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string CellphoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool Administrator { get; set; }
        public string UserName { get; set; }
        public string UserPWD { get; set; }
        public int LocalityID { get; set; }
        public string LicenceNumber { get; set; }

        public DateTime LicenceObtentionDate { get; set; }
        public DateTime LicenceExpirationDate { get; set; }
        public string LicenceCountry { get; set; }

        public bool QualificationType1 { get; set; }
        public bool QualificationType2 { get; set; }
        public bool QualificationType3 { get; set; }
        public bool QualificationType4 { get; set; }
        public bool QualificationType5 { get; set; }
        public bool QualificationType6 { get; set; }

        public bool IsPilot => LicenceNumber != null;
        public bool IsSupporter => !IsPilot;

        public string FullName
        {
            get { return $"{LastName.ToUpper()} {FirstName}"; }
        }

        public string MemberCategory
        {
            get
            {
                string memberCategory = "Autre";

                if (IsPilot)
                    memberCategory = "Pilote";
                if (IsSupporter)
                    memberCategory = "Sympathisant";

                return memberCategory;
            }
        }

        public override string ToString()
        {
            return $"{FullName} / {MemberCategory}";
        }
    }
}
