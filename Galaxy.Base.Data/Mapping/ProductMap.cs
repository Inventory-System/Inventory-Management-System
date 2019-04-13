using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class ProductMap : IAutoMappingOverride<Product>
    {
        public void Override(AutoMapping<Product> mapping)
        {
            mapping.Map(x => x.Name).Not.Nullable().Length(50);
            mapping.References(x => x.SubsidiaryMeasurement);
            mapping.References(x => x.measurement).Column("Measurement");
        }
    }
}