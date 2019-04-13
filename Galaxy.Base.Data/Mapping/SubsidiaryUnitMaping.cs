using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class SubsidiaryUnitMaping : IAutoMappingOverride<SubsidiaryUnit>
    {
        public void Override(AutoMapping<SubsidiaryUnit> mapping)
        {
            mapping.Map(c => c.SubsidiaryUnitName);
            mapping.Map(c => c.Coefficient);
            mapping.References(c => c.measurement).Not.Nullable().Column("Measurement");
        }
    }
}