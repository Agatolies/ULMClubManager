using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Models;
using ULMClubManager.DAL.Repositories;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";

            LocRepository locRepository = new LocRepository(connectionString);

            //ReadAll(locRepository);
            //ReadOne(locRepository);
            //CreateOne(locRepository);
            //UpdateOne(locRepository);
            DeleteOne(locRepository);

            Console.WriteLine("ok");

            Console.ReadLine();
        }

        private static void DeleteOne(LocRepository locRepository)
        {
            locRepository.DeleteOne(8);
        }

        private static void UpdateOne(LocRepository locRepository)
        {
            Loc loc = locRepository.ReadOne(8);

            loc.LOC_NOM = "Longdoz";

            locRepository.UpdateOne(loc);
        }

        private static void CreateOne(LocRepository locRepository)
        {
            Loc newLoc = new Loc() { LOC_CP = "4020", LOC_NOM = "Longdoz" };

            locRepository.CreateOne(newLoc);
        }

        private static void ReadAll(LocRepository locRepository)
        {
            IEnumerable<Loc> localites = locRepository.ReadAll();

            foreach (var item in localites)
            {
                Console.WriteLine(item.LOC_NOM);
            }
        }

        private static void ReadOne(LocRepository locRepository)
        {
            Loc localite = locRepository.ReadOne(3);

            Console.WriteLine(localite.LOC_NOM);
        }

    }
}
