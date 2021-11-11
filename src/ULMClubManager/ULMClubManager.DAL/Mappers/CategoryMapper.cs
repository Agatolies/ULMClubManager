using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers;

public class CategoryMapper : GenericMapper<TypDBRow, AircraftCategory>
{
    public override AircraftCategory From(TypDBRow typ)
    {
        return new AircraftCategory(typ.TYP_ID, typ.TYP_NOM, typ.TYP_DES);
    }

    public override TypDBRow To(AircraftCategory typ)
    {
        TypDBRow result = new TypDBRow();

        if (typ.ID.HasValue)
            result.TYP_ID = typ.ID.Value;

        result.TYP_NOM = typ.Name;
        result.TYP_DES = typ.Description;

        return result;
    }
}