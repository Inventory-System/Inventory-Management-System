using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    class CalculationFactorMap:IAutoMappingOverride<CalculationFactor>
    {
        public void Override(AutoMapping<CalculationFactor> mapping)
        {
            mapping.Map(x => x.CalculatedPrice);
            mapping.References(x => x.Factor).Not.Nullable();
          //  mapping.HasOne(x => x.ProductDocument);
        }
    }
}
