using System;
using ULMClubManager.BL.Services;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {
        static void Main(string[] args)
        {
            SupporterService supporterService = new SupporterService();

            foreach (var supporter in supporterService.ReadAll())
            {
                Console.WriteLine(supporter);
            }
            //localityService.ReadOne();
            //Console.WriteLine(pilotService.CreateOne());
            //pilotService.UpdateOne();
            //localityService.DeleteOne();

            Console.WriteLine("ok");

            Console.ReadLine();
        }
    }
}
