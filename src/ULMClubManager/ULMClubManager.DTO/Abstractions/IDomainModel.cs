namespace ULMClubManager.DTO.Abstractions
{
    /// <summary>
    /// Interface de base pour la représentation de nos entités métiers
    /// </summary>
    public interface IDomainModel
    {
        /// <summary>
        /// Identifiant de l'entité (peut être nul lors de la création)
        /// </summary>
        int? ID { get; }
    }
}
