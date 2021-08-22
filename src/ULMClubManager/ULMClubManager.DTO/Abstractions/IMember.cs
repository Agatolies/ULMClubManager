using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULMClubManager.DTO.Abstractions 
{
    public interface IMember : IDomainModel
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string Sex { get; set; }
        DateTime DateOfBirth { get; set; }
        DateTime RegistrationDate { get; set; }
        string Street { get; set; }
        string ResidenceName { get; set; }
        string BuildingNumber { get; set; }
        string BoxNumber { get; set; }
        string PhoneNumber { get; set; }
        string CellphoneNumber { get; set; }
        string EmailAddress { get; set; }
        bool Administrator { get; set; }
        string UserName { get; set; }
        string UserPWD { get; set; }
        int LocalityID { get; set; }
        Qualification Qualification { get; set; }

        string FullName { get; }
    }
}
