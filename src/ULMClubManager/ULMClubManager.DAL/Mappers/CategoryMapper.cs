using ULMClubManager.DAL.DBRowModels;
using ULMClubManager.DAL.DomainModels;

namespace ULMClubManager.DAL.Mappers
{
    public class CategoryMapper : GenericMapper<TypDBRow, Category>
    {
        public override Category From(TypDBRow typ)
        {
            return new Category(typ.TYP_ID, typ.TYP_NOM, typ.TYP_DES);
        }

        public override TypDBRow To(Category typ)
        {
            TypDBRow result = new TypDBRow();

            if (typ.ID.HasValue)
                result.TYP_ID = typ.ID.Value;

            result.TYP_NOM = typ.Name;
            result.TYP_DES = typ.Description;

            return result;
        }
    }
}
