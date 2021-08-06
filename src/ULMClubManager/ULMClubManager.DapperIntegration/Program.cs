using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ULMClubManager.DapperIntegration
{

    public class Loc
    {
        public int LOC_ID { get; set; }
        public string LOC_CP { get; set; }
        public string LOC_NOM { get; set; }
    }


    public class Program
    {
        private static string connectionString;

        static void Main(string[] args)
        {
            connectionString = "Data Source=localhost;Initial Catalog=ULMClubManager;Persist Security Info=True;User ID=sa;Password=<YourStrong@Passw0rd>";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                IEnumerable<Loc> localites = connection.Query<Loc>("select * from LOC");

                foreach (var item in localites)
                {
                    Console.WriteLine(item.LOC_NOM);
                }

            }
            
            Console.ReadLine();
        }
    }
}
