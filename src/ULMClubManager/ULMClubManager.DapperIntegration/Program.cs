using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DAL.Repositories;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";
            LocalityMapper mapper = new LocalityMapper();

            LocalityRepository locRepository = new LocalityRepository(connectionString, mapper);

            //ReadAll(locRepository);
            //ReadOne(locRepository);
            //CreateOne(locRepository);
            //UpdateOne(locRepository);
            //DeleteOne(locRepository);

            Console.WriteLine("ok");

            Console.ReadLine();
        }

        private static void DeleteOne(LocalityRepository locRepository)
        {
            locRepository.DeleteOne(8);
        }

        private static void UpdateOne(LocalityRepository locRepository)
        {
            Locality loc = locRepository.ReadOne(8);
            loc.Name = "Longdoz";
            locRepository.UpdateOne(loc);
        }

        private static void CreateOne(LocalityRepository locRepository)
        {
            Locality newLoc = new Locality("4020", "Longdoz");
            locRepository.CreateOne(newLoc);
        }

        private static void ReadAll(LocalityRepository locRepository)
        {
            IEnumerable<Locality> localites = locRepository.ReadAll();

            foreach (var item in localites)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReadOne(LocalityRepository locRepository)
        {
            Locality localite = locRepository.ReadOne(3);
            Console.WriteLine(localite);
        }

    }
}
