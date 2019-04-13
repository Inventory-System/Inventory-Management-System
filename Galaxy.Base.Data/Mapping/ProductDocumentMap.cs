using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class ProductDocumentMap : IAutoMappingOverride<ProductDocument>
    {
        public void Override(AutoMapping<ProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Profit);
            mapping.Map(x => x.Price);
            mapping.References(x => x.product).Not.Nullable().Column("Product");
            mapping.HasMany(x => x.CalculationFactorsList);
          
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