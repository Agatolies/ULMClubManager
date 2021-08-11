using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public class SupporterService
    {
        public List<Supporter> ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Supporters.ReadAll().ToList();
            }
        }
    }
}
