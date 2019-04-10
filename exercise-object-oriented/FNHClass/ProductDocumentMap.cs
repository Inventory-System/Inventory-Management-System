using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHFolder
{
    public class ProductDocumentMap : IAutoMappingOverride<ProductDocument>
    {
        public void Override(AutoMapping<ProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Profit);
            mapping.Map(x => x.SellingPrice);
            mapping.References(x => x.product).Not.Nullable().Column("Product");
        }
    }

    public class GenericProductDocumentMap : IAutoMappingOverride<ProductDocument<Document>>
    {
        public void Override(AutoMapping<ProductDocument<Document>> mapping)
        {
            mapping.HasOne(x => x.Document);
        }
    }
}