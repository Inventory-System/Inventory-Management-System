using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class MeasurementMap : IAutoMappingOverride<Measurement>
    {
        public void Override(AutoMapping<Measurement> mapping)
        {
            mapping.Map(x => x.Name).Length(20).Not.Nullable();
        }
    }
}