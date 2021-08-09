using System;

namespace ULMClubManager.DAL.DBRowModels
{
    public class PilDBRow : MbrDBRow
    {
        public string PIL_NUM_LIC { get; set; }
        public DateTime PIL_LIC_DTE_OBT { get; set; }
        public DateTime PIL_LIC_DTE_EXP { get; set; }
        public string PIL_LIC_PAYS { get; set; }
    }
}
