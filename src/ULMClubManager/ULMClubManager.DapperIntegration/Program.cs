using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DapperIntegration.Repositories;

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
            //DeleteOne(locRepository);

            Console.WriteLine("ok");

            Console.ReadLine();
        }

        private static void DeleteOne(LocRepository locRepository)
        {
            locRepository.DeleteOne(7);
        }

        private static void UpdateOne(LocRepository locRepository)
        {
            TModel updatedLoc = new TModel() { LOC_ID = 7, LOC_CP = "4020", LOC_NOM = "Longdoz" };

            locRepository.UpdateOne(updatedLoc);
        }

        private static void CreateOne(LocRepository locRepository)
        {
            TModel newLoc = new TModel() { LOC_CP = "4020", LOC_NOM = "Longdoz" };

            locRepository.CreateOne(newLoc);
        }

        private static void ReadAll(LocRepository locRepository)
        {
            IEnumerable<TModel> localites = locRepository.ReadAll();

            foreach (var item in localites)
            {
                Console.WriteLine(item.LOC_NOM);
            }
        }

        private static void ReadOne(LocRepository locRepository)
        {
            TModel localite = locRepository.ReadOne(3);

            Console.WriteLine(localite.LOC_NOM);
        }

    }
}
