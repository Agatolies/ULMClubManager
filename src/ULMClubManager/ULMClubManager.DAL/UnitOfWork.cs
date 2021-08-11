using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.Mappers;
using ULMClubManager.DAL.Repositories;

namespace ULMClubManager.DAL
{
    /// <summary>
    /// Design pattern standard responsable de la gestion des transactions DB. 
    /// Expose une transaction et permet de démarrer, de valider ou d'annuler une transaction.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public UnitOfWork(IDbConnection connection)
        {
            _connection = connection;
        }

        public IDbConnection Connection
        {
            get { return _connection; }
        }

        public IDbTransaction Transaction
        {
            get { return _transaction; }
        }

        public void Begin()
        {
            _transaction = _connection.BeginTransaction();
            // La méthode BeginTransaction fait partie de l'interface IDbConnection (using System.Data)
        }

        public void Commit()
        {
            _transaction.Commit();
            Dispose();
        }

        public void Rollback()
        {
            _transaction.Rollback();
            Dispose();
        }

        public void Dispose()
        {
            if (_transaction != null)
                _transaction.Dispose();

            _transaction = null;
        }

    }
}
