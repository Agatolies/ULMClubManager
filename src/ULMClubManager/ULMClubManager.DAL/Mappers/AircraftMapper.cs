using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers
{
    public class AircraftMapper : GenericMapper<AerDBRow, Aircraft>
    {
        public override Aircraft From(AerDBRow aer)
        {
            return new Aircraft(aer.AER_ID, aer.AER_IMA, aer.TYP_FK_ID);
        }

        public override AerDBRow To(Aircraft aer)
        {
            AerDBRow result = new AerDBRow();

            if (aer.ID.HasValue)
                result.AER_ID = aer.ID.Value;

            result.AER_IMA = aer.Registration;
            result.TYP_FK_ID = aer.CategoryID;

            return result;
        }
    }
}
