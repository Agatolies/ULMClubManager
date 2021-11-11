using ULMClubManager.DTO;

namespace ULMClubManager.BL
{
    /// <summary>
    /// Classe statique utilisée avec le Login 
    /// et permettant de définir quel est l'utilisateur connecté
    /// </summary>
    public static class State
    {
        public static Member? User { get; internal set; }
        public static bool IsAdmin => User.Administrator;
    }
}
