using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DTO;

namespace ULMClubManager.DAL.Mappers;

public class LocalityMapper : GenericMapper<LocDBRow, Locality>
{
    public override Locality From(LocDBRow loc)
    {
        return new Locality(loc.LOC_ID, loc.LOC_CP, loc.LOC_NOM);
    }

    public override LocDBRow To(Locality loc)
    {
        LocDBRow result = new LocDBRow();

        if (loc.ID.HasValue)
            result.LOC_ID = loc.ID.Value;

        result.LOC_CP = loc.ZipCode;
        result.LOC_NOM = loc.Name;

        return result;
    }
}