using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.Mapping
{
    public class ProductMap : IAutoMappingOverride<Product>
    {
        public void Override(AutoMapping<Product> mapping)
        {
            mapping.Map(x => x.Name).Not.Nullable().Length(50);
            mapping.HasMany(x => x.SubsidiaryUnitList);
            mapping.References(x => x.measurement).Column("Measurement");
        }
    }
}