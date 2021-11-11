using ULMClubManager.DTO.Abstractions;

namespace ULMClubManager.DAL.Mappers;

/// <summary>
/// Classe générique permettant la transformation d'un modèle SQL vers le domaine métier
/// </summary>
/// <typeparam name="TDBRow">La classe représentant un enregistrement d'une table SQL</typeparam>
/// <typeparam name="TDomain">Le classe représentant un modèle du domaine</typeparam>
public abstract class GenericMapper<TDBRow, TDomain> 
    where TDomain : class, IDomainModel
{
    /// <summary>
    /// Convertis un enregistrement d'une table SQL en une entité métier
    /// </summary>
    public abstract TDomain From(TDBRow model);

    /// <summary>
    /// Convertis une entité métier en un enregistrement d'une table SQL
    /// </summary>
    public abstract TDBRow To(TDomain domainModel);

    public List<TDomain> From(IEnumerable<TDBRow> models)
    {
        List<TDomain> domainModels = new List<TDomain>();
        foreach (TDBRow model in models)
        {
            TDomain domainModel = this.From(model);
            domainModels.Add(domainModel);
        }

        return domainModels;
    }

    public List<TDBRow> To(IEnumerable<TDomain> domainModels)
    {
        List<TDBRow> models = new List<TDBRow>();
        foreach (TDomain domainModel in domainModels)
        {
            TDBRow model = this.To(domainModel);
            models.Add(model);
        }

        return models;
    }
}