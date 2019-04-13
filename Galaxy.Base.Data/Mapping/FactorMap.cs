using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    class FactorMap : IAutoMappingOverride<Factor>
    {
        public void Override(AutoMapping<Factor> mapping)
        {
            mapping.Map(x => x.Name).Length(20).Not.Nullable();
            mapping.Map(x => x.Priority).Not.Nullable();
            mapping.Map(x => x.Operation).Not.Nullable();
            mapping.Map(x => x.Increasing).Not.Nullable();
            mapping.Map(x => x.Quantity).Not.Nullable();
        }
    }
}