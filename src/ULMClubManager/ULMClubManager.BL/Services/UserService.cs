using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

namespace ULMClubManager.BL.Services;

public static class UserService
{
    public static void Login(string userName, string password)
    {
        using (DalSession dalSession = new DalSession())
        {
            int memberID = dalSession.Members.Match(userName, password);
            Member member = dalSession.Members.ReadOne(memberID); 

            if (member.Administrator)
                State.User = member;
            else
                throw new LoginAdminException();
        }
    }
}