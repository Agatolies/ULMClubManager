using System.Collections.Generic;
using ULMClubManager.DAL.Abstractions;
using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class AircraftMapper : GenericMapper<AerDBRow, Aircraft>
    {
        public override Aircraft From(AerDBRow aer)
        {
            return new Aircraft(aer.AER_ID, aer.AER_IMA, aer.AER_TYPE, aer.TYP_ID);
        }

        public override AerDBRow To(Aircraft aer)
        {
            AerDBRow result = new AerDBRow();

            if (aer.ID.HasValue)
                result.AER_ID = aer.ID.Value;

            result.AER_IMA = aer.Registration;
            result.AER_TYPE = aer.Type;
            result.TYP_ID = aer.TypeID;

            return result;
        }
    }
}
