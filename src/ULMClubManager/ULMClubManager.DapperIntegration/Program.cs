using System;
using System.Collections.Generic;
using ULMClubManager.DAL;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadAll();
            //ReadOne();
            //CreateOne();
            //UpdateOne();
            //DeleteOne();

            Console.WriteLine("ok");

            Console.ReadLine();
        }

        private static void DeleteOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                dalSession.Localities.DeleteOne(8);
            }
        }

        private static void UpdateOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Locality loc = dalSession.Localities.ReadOne(8);
                loc.Name = "Longdoz";
                dalSession.Localities.UpdateOne(loc);
            }
        }

        private static void CreateOne()
        {
            using(DalSession dalSession = new DalSession())
            {
                Locality newLoc = new Locality("4020", "Longdoz");
                dalSession.Localities.CreateOne(newLoc);
            }
        }

        private static void CreateOneWithTransaction()
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

        private static void ReadAll()
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

        private static void ReadOne()
        {
            using (DalSession dalSession = new DalSession())
            {
                Locality localite = dalSession.Localities.ReadOne(3);
                Console.WriteLine(localite);
            }
        }
    }
}
