using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.Mapping
{
    public class MeasurementMap : IAutoMappingOverride<Measurement>
    {
        public void Override(AutoMapping<Measurement> mapping)
        {
            mapping.Map(x => x.Name).Length(20).Not.Nullable();
        }
    }
}