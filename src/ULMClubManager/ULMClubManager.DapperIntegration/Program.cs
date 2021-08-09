using System;
using ULMClubManager.BL.Services;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {
        static void Main(string[] args)
        {
            LocalityService localityService = new LocalityService();

            localityService.ReadAll();
            //localityService.ReadOne();
            //localityService.CreateOne();
            //localityService.UpdateOne();
            //localityService.DeleteOne();

            Console.WriteLine("ok");

            Console.ReadLine();
        }
    }
}
