using ULMClubManager.DTO;

namespace ULMClubManager.BL
{
    public static class State
    {
        public static Member User { get; internal set; }
        public static bool IsAdmin => User.Administrator;
    }
}
