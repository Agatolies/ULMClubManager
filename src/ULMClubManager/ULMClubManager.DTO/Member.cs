﻿using System;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DTO
{
    public class Member : IDomainModel
    {
        public Member(int? id, string lastName, string firstName, string sex, 
            DateTime dateOfBirth, DateTime registrationDate, string street, 
            string residenceName, string buildingNumber, string boxNumber, 
            string phoneNumber, string cellphoneNumber, string emailAddress, 
            bool administrator, string userName, string userPWD, int localityID)
        {
            ID = id;
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
        }

        public Member(string lastName, string firstName, string sex,
            DateTime dateOfBirth, DateTime registrationDate, string street,
            string residenceName, string buildingNumber, string boxNumber,
            string phoneNumber, string cellphoneNumber, string emailAddress,
            bool administrator, string userName, string userPWD, int localityID)
            : this(null, lastName, firstName, sex, 
                  dateOfBirth, registrationDate, street, 
                  residenceName, buildingNumber, boxNumber,
                  phoneNumber, cellphoneNumber, emailAddress,
                  administrator, userName, userPWD, localityID)
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
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return $"L'utilisateur {FullName}";
        }
    }
}