using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using Dapper;
using ULMClubManager.DAL.Mappers;

namespace ULMClubManager.DAL.Abstractions
{
    public abstract class GenericRepository<TDBRow, TKey, TDomain> 
        : IGenericRepository<TDomain, TKey> where TDomain : class, IDomainModel
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
        private readonly string _keyPrefix;
        private readonly GenericMapper<TDBRow, TDomain> _mapper;

        public GenericRepository(string connectionString, string tableName, string keyPrefix, GenericMapper<TDBRow, TDomain> mapper)
        { 
            _connectionString = connectionString;
            _tableName = tableName;
            _keyPrefix = keyPrefix;
            _mapper = mapper;
        }

        public GenericRepository(string connectionString, string tableName, GenericMapper<TDBRow, TDomain> mapper)
            : this(connectionString, tableName, tableName, mapper)
        {
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
            Type type = typeof(TDBRow);
            return type.GetProperties();
        }

        public virtual TDomain CreateOne(TDomain domainModel)
        {
            string query = GenerateInsertQuery();

            using (SqlConnection connection = CreateConnection())
            {
                TDBRow model = _mapper.To(domainModel);
                connection.Execute(query, model);
                return ReadLast();
            }
        }

        public virtual int CreateMany(IEnumerable<TDomain> domainModels)
        {
            int inserted = 0;
            string query = GenerateInsertQuery();

            using (SqlConnection connection = CreateConnection())
            {
                List<TDBRow> models = _mapper.To(domainModels);
                inserted += connection.Execute(query, models);
            }

            return inserted;
        }

        public virtual void DeleteOne(TKey id)
        {
            string sql = $"DELETE FROM {_tableName} WHERE {_keyPrefix}_ID = @ID";

            using (SqlConnection connection = CreateConnection())
            {
                int affectedRows = connection.Execute(sql, new { ID = id });
                if (affectedRows == 0)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");
            }
        }

        public virtual IEnumerable<TDomain> ReadAll()
        {
            string query = $"SELECT * FROM {_tableName}";

            using (SqlConnection connection = CreateConnection())
            {
                IEnumerable<TDBRow> models = connection.Query<TDBRow>(query);
                return _mapper.From(models);
            }
        }

        public virtual TDomain ReadOne(TKey id)
        {
            string query = $"SELECT * FROM {_tableName} WHERE {_keyPrefix}_ID = @ID";

            using (SqlConnection connection = CreateConnection())
            {
                TDBRow result = connection.QueryFirstOrDefault<TDBRow>(query, new { ID = id });
                if (result == null)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

                return _mapper.From(result);
            }
        }

        public virtual TDomain ReadLast()
        {
            string query = $"SELECT TOP 1 * FROM {_tableName} ORDER BY unique_column DESC";

            using (SqlConnection connection = CreateConnection())
            {
                TDBRow result = connection.QueryFirstOrDefault<TDBRow>(query);
                return _mapper.From(result);
            }
        }

        public virtual void UpdateOne(TDomain domainModel)
        {
            string query = GenerateUpdateQuery();

            using (SqlConnection connection = CreateConnection())
            {
                TDBRow model = _mapper.To(domainModel);
                int affectedRows = connection.Execute(query, model);
                if (affectedRows == 0)
                    throw new KeyNotFoundException($"La table {_tableName} avec l'id [{domainModel.ID}] n'existe pas.");
            }
        }

        protected virtual string GenerateInsertQuery()
        {
            StringBuilder query = new StringBuilder($"INSERT INTO {_tableName}");

            query.Append("(");

            List<string> properties = GenerateListOfProperties(GetProperties());

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_keyPrefix}_ID"))
                    query.Append($"[{prop}],");
            }

            query.Remove(query.Length - 1, 1);
            query.Append(") VALUES (");

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_keyPrefix}_ID")) 
                    query.Append($"@{prop},");
            }

            query.Remove(query.Length - 1, 1);
            query.Append(")");

            return query.ToString();
        }

        protected virtual string GenerateUpdateQuery()
        {
            StringBuilder query = new StringBuilder($"UPDATE {_tableName} SET ");
            List<string> properties = GenerateListOfProperties(GetProperties());

            foreach (string prop in properties)
            {
                if (!prop.Equals($"{_keyPrefix}_ID"))
                    query.Append($"{prop}=@{prop},");
            }

            query.Remove(query.Length - 1, 1);
            query.Append($" WHERE {_keyPrefix}_ID=@{_keyPrefix}_ID");

            return query.ToString();
        }
    }
}
