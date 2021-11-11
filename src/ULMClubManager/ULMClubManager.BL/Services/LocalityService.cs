using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class LocalityService
    {
        public static List<Locality> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Localities.ReadAll();
            }
        }
    }
}
