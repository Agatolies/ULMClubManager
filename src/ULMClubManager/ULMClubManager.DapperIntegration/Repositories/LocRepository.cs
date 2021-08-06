using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using ULMClubManager.DapperIntegration.Models;

namespace ULMClubManager.DapperIntegration.Repositories
{

    // CRUD = Create, Read, Update, Delete

    public class LocRepository : IRepository<Loc, int>
    {
        private readonly string _connectionString;

        public LocRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void CreateOne(Loc loc)
        {
            string sql = @"INSERT INTO LOC(LOC_CP, LOC_NOM) VALUES (@Zipcode, @Name)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int affectedRows = connection.Execute(sql, new { Zipcode = loc.LOC_CP, Name = loc.LOC_NOM });
            }
        }

        public IEnumerable<Loc> ReadAll()
        {
            string sql = "SELECT * FROM LOC";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                IEnumerable<Loc> localites = connection.Query<Loc>(sql);

                return localites;
            }
        }

        public Loc ReadOne(int id)
        {
            string sql = "SELECT * FROM LOC WHERE LOC_ID = @LocalityID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Loc localite = connection.QueryFirstOrDefault<Loc>(sql, new { LocalityID = id });

                return localite;
            }
        }

        public void UpdateOne(Loc loc)
        {
            string sql = @"UPDATE LOC SET LOC_CP = @Zipcode, LOC_NOM = @Name WHERE LOC_ID = @LocalityID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int affectedRows = connection.Execute(sql, new { LocalityID = loc.LOC_ID, Zipcode = loc.LOC_CP, Name = loc.LOC_NOM });
            }
        }

        public void DeleteOne(int id)
        {
            string sql = "DELETE FROM LOC WHERE LOC_ID = @LocalityID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int affectedRows = connection.Execute(sql, new { LocalityID = id });
            }
        }
    }
}
