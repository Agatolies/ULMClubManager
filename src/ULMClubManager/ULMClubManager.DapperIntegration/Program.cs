using System;
using System.Collections.Generic;
using ULMClubManager.BL.Services;
using ULMClubManager.DTO;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DapperIntegration
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (Member member in MemberService.ReadAll())
            {
                Console.WriteLine(member);
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
