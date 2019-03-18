using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.FNHClass
{
    public class SubsidiaryUnitMapin : IAutoMappingOverride<SubsidiaryUnit>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<SubsidiaryUnit> mapping)
        {
            mapping.Map(c => c.SubsidiaryUnitName);
            mapping.Map(c => c.Cunt);
            mapping.References(c => c.measurement).Not.Nullable().Column("Measurement");
        }
    }
}
