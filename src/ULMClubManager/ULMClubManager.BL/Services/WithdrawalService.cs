using System;
using System.Collections.Generic;
using System.Linq;
using ULMClubManager.DAL;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public static class WithdrawalService
    {
        public static List<Withdrawal> ReadAllWithdrawalsByPilotID(int pilotID)
        {
            using (DalSession dalSession = new DalSession())
            {
                return dalSession.Withdrawals.ReadAllWithdrawalsByPilotID(pilotID).ToList();
            }
        }

        public static void CreateOne(Withdrawal withdrawal)
        {
            ValidateWithdrawal(withdrawal);

            using (DalSession dalSession = new DalSession())
            {
                dalSession.Withdrawals.CreateOne(withdrawal);
            }
        }

        public static bool HasWithdrawalToday(int pilotID)
        {
            List<Withdrawal> withdrawals = ReadAllWithdrawalsByPilotID(pilotID);
            DateTime today = DateTime.Now;

            return withdrawals
                .Any(w => w.StartDate <= today && w.EndDate >= today);
        }

        private static void ValidateWithdrawal(Withdrawal withdrawal)
        {
        }
    }
}
