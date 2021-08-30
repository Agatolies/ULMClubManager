using System;
using System.Collections.Generic;
using System.Linq;
using ULMClubManager.DAL;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Exceptions;

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
                try
                {
                    dalSession.UnitOfWork.Begin();
                    dalSession.Withdrawals.CreateOne(withdrawal);
                    dalSession.UnitOfWork.Commit();
                }
                catch (Exception)
                {
                    dalSession.UnitOfWork.Rollback();
                    throw;
                }
            }
        }

        public static bool HasWithdrawalByDate(int pilotID, DateTime date)
        {
            List<Withdrawal> withdrawals = ReadAllWithdrawalsByPilotID(pilotID);

            return withdrawals
                .Any(w => w.StartDate <= date && w.EndDate >= date);
        }

        private static void ValidateWithdrawal(Withdrawal withdrawal)
        {
            if (withdrawal.StartDate >= withdrawal.EndDate)
                throw new InvalidLicenceDatesException();
        }
    }
}
