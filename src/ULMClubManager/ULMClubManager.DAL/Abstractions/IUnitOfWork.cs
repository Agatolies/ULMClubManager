using System.Data;

namespace ULMClubManager.DAL.Abstractions;

/// <summary>
/// Représente une unité de travail
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IDbConnection Connection { get; }
    IDbTransaction? Transaction { get; }

    /// <summary>
    /// Démarre une transaction SQL
    /// </summary>
    void Begin();

    /// <summary>
    /// Valide les changements envoyés vers la DB
    /// </summary>
    void Commit();

    /// <summary>
    /// Annule une transaction SQL
    /// </summary>
    void Rollback();
}