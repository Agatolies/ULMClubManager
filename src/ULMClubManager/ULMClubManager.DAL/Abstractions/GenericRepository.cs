using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using Dapper;

namespace ULMClubManager.DAL.Abstractions
{
    public abstract class GenericRepository<TModel, TKey> 
        : IGenericRepository<TModel, TKey> where TModel : class
    {
        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties)
        {
            // TODO revoir la logique Linq

            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length <= 0 || (attributes[0] as DescriptionAttribute)?.Description != "ignore"
                    select prop.Name).ToList();
        }

        private readonly string _connectionString;
        private readonly string _tableName;

        public GenericRepository(string connectionString, string tableName)
        {
            _connectionString = connectionString;
            _tableName = tableName;
        }

        private SqlConnection SqlConnection()
        {
            return new SqlConnection(_connectionString);
        }

        private SqlConnection CreateConnection()
        {
            SqlConnection conn = SqlConnection();
            conn.Open();
            return conn;
        }

        private IEnumerable<PropertyInfo> GetProperties()
        {
            Type type = typeof(TModel);
            return type.GetProperties();
        }

        public void CreateOne(TModel model)
        {
            string query = GenerateInsertQuery();

            using (SqlConnection connection = CreateConnection())
            {
                connection.Execute(query, model);
            }
        }

        public int CreateMany(IEnumerable<TModel> models)
        {
            int inserted = 0;
            string query = GenerateInsertQuery();

            using (SqlConnection connection = CreateConnection())
            {
                inserted += connection.Execute(query, models);
            }

            return inserted;
        }

        public void DeleteOne(TKey id)
        {
            string sql = $"DELETE FROM {_tableName} WHERE {_tableName}_ID = @ID";

            using (SqlConnection connection = CreateConnection())
            {
                int affectedRows = connection.Execute(sql, new { ID = id });
                if (affectedRows == 0)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");
            }
        }

        public IEnumerable<TModel> ReadAll()
        {
            string query = $"SELECT * FROM {_tableName}";

            using (SqlConnection connection = CreateConnection())
            {
                return connection.Query<TModel>(query);
            }
        }

        public TModel ReadOne(TKey id)
        {
            string query = $"SELECT * FROM {_tableName} WHERE {_tableName}_ID = @ID";

            using (SqlConnection connection = CreateConnection())
            {
                TModel result = connection.QueryFirstOrDefault<TModel>(query, new { ID = id });
                if (result == null)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

                return result;
            }
        }

        public void UpdateOne(TModel model)
        {
            string query = GenerateUpdateQuery();

            using (SqlConnection connection = CreateConnection())
            {
                int affectedRows = connection.Execute(query, model);
                if (affectedRows == 0)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");
            }
        }

        private string GenerateInsertQuery()
        {
            StringBuilder query = new StringBuilder($"INSERT INTO {_tableName}");

            query.Append("(");

            List<string> properties = GenerateListOfProperties(GetProperties());

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_tableName}_ID"))
                    query.Append($"[{prop}],");
            }

            query.Remove(query.Length - 1, 1);
            query.Append(") VALUES (");

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_tableName}_ID")) 
                    query.Append($"@{prop},");
            }

            query.Remove(query.Length - 1, 1);
            query.Append(")");

            return query.ToString();
        }

        private string GenerateUpdateQuery()
        {
            StringBuilder query = new StringBuilder($"UPDATE {_tableName} SET ");
            List<string> properties = GenerateListOfProperties(GetProperties());

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_tableName}_ID"))
                    query.Append($"{prop}=@{prop},");
            }

            query.Remove(query.Length - 1, 1);
            query.Append($" WHERE {_tableName}_ID=@{_tableName}_ID");

            return query.ToString();
        }
    }
}
