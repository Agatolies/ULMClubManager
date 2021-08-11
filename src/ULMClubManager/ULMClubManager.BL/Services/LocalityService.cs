using System;
using System.Collections.Generic;
using ULMClubManager.DAL;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DTO;

namespace ULMClubManager.BL.Services
{
    public class LocalityService
    {
        public void DeleteOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                dalSession.Localities.DeleteOne(8);
            }
        }

        public void UpdateOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Locality loc = dalSession.Localities.ReadOne(8);
                loc.Name = "Longdoz";
                dalSession.Localities.UpdateOne(loc);
            }
        }

        public void CreateOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Locality newLoc = new Locality("4020", "Longdoz");
                dalSession.Localities.CreateOne(newLoc);
            }
        }

        public void CreateOneWithTransaction()
        {
            using (DalSession dalSession = new DalSession())
            {
                IUnitOfWork unitOfWork = dalSession.UnitOfWork;
                unitOfWork.Begin();
                try
                {
                    Locality newLoc = new Locality("4020", "Longdoz");
                    dalSession.Localities.CreateOne(newLoc);
                    unitOfWork.Commit();
                }
                catch
                {
                    unitOfWork.Rollback();
                    throw;
                }
            }
        }

        public void ReadAll()
        {
            using (DalSession dalSession = new DalSession())
            {
                IEnumerable<Locality> localites = dalSession.Localities.ReadAll();

                foreach (var item in localites)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void ReadOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Locality localite = dalSession.Localities.ReadOne(3);
                Console.WriteLine(localite);
            }
        }
    }
}
