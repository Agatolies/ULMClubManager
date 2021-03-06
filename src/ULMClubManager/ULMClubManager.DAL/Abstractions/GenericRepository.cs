using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Dapper;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DAL.Abstractions
{
    /// <summary>
    /// Classe générique permettant un accès aux données de notre base de données SQL
    /// </summary>
    /// <typeparam name="TDBRow">La classe représentant un enregistrement d'une table SQL</typeparam>
    /// <typeparam name="TKey">Le type de la clé d'un enregistrement</typeparam>
    /// <typeparam name="TDomain">Le classe représentant un modèle du domaine</typeparam>
    public abstract class GenericRepository<TDBRow, TKey, TDomain>
        : IGenericRepository<TDomain, TKey>
        where TDomain : class, IDomainModel
    {
        /// <summary>
        /// Utilise le mécanisme de "reflection" pour obtenir la liste des propriété d'une classe
        /// </summary>
        private static List<string> GenerateListOfProperties(IEnumerable<PropertyInfo> listOfProperties)
        {
            return (from prop in listOfProperties
                    let attributes = prop.GetCustomAttributes(typeof(DescriptionAttribute), false)
                    where attributes.Length <= 0 || (attributes[0] as DescriptionAttribute)?.Description != "ignore"
                    select prop.Name).ToList();
        }

        protected readonly IUnitOfWork _unitOfWork;
        protected readonly string _tableName;
        protected readonly string _keyPrefix;
        protected readonly GenericMapper<TDBRow, TDomain> _mapper;

        public GenericRepository(IUnitOfWork unitOfWork, string tableName, string keyPrefix, GenericMapper<TDBRow, TDomain> mapper)
        {
            _unitOfWork = unitOfWork;
            _tableName = tableName;
            _keyPrefix = keyPrefix;
            _mapper = mapper;
        }

        public GenericRepository(IUnitOfWork unitOfWork, string tableName, GenericMapper<TDBRow, TDomain> mapper)
            : this(unitOfWork, tableName, tableName, mapper)
        {
        }

        private IEnumerable<PropertyInfo> GetProperties()
        {
            Type type = typeof(TDBRow);
            return type.GetProperties();
        }

        public virtual TDomain CreateOne(TDomain domainModel)
        {
            string sql = GenerateInsertQuery();

            TDBRow model = _mapper.To(domainModel);
            _unitOfWork.Connection.Execute(sql, model, transaction: _unitOfWork.Transaction);

            return ReadLast();
        }

        public virtual int DeleteOne(TKey id)
        {
            string sql = $"DELETE FROM {_tableName} WHERE {_keyPrefix}_ID = @ID";

            int affectedRows = _unitOfWork.Connection.Execute(sql, new { ID = id }, transaction: _unitOfWork.Transaction);
            if (affectedRows == 0)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return affectedRows;
        }

        public virtual List<TDomain> ReadAll()
        {
            string query = $"SELECT * FROM {_tableName}";
            IEnumerable<TDBRow> models = _unitOfWork.Connection.Query<TDBRow>(query, transaction: _unitOfWork.Transaction);
            return _mapper.From(models);
        }

        public virtual TDomain ReadOne(TKey id)
        {
            string query = $"SELECT * FROM {_tableName} WHERE {_keyPrefix}_ID = @ID";

            TDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<TDBRow>(query, new { ID = id }, transaction: _unitOfWork.Transaction);
            if (result == null)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{id}] n'existe pas.");

            return _mapper.From(result);
        }

        public virtual TDomain ReadLast()
        {
            string query = $"SELECT TOP 1 * FROM {_tableName} ORDER BY {_keyPrefix}_ID DESC";
            TDBRow result = _unitOfWork.Connection.QueryFirstOrDefault<TDBRow>(query, transaction: _unitOfWork.Transaction);
            return _mapper.From(result);
        }

        public virtual void UpdateOne(TDomain domainModel)
        {
            string query = GenerateUpdateQuery();

            TDBRow model = _mapper.To(domainModel);
            int affectedRows = _unitOfWork.Connection.Execute(query, model, transaction: _unitOfWork.Transaction);
            if (affectedRows == 0)
                throw new KeyNotFoundException($"La table {_tableName} avec l'id [{domainModel.ID}] n'existe pas.");
        }

        /// <summary>
        /// Utilise un string builder pour générer un requête d'insertion en base de données;
        /// </summary>
        protected virtual string GenerateInsertQuery()
        {
            StringBuilder query = new StringBuilder($"INSERT INTO {_tableName} ");

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

        /// <summary>
        /// Utilise un string builder pour générer un requête de mise à jour en base de données;
        /// </summary>
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
