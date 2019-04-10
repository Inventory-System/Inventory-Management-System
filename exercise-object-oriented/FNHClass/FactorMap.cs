using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHClass
{
    class FactorMap : IAutoMappingOverride<Factor>
    {
        public void Override(AutoMapping<Factor> mapping)
        {
            mapping.Map(x => x.Name).Length(20).Not.Nullable();
            mapping.Map(x => x.Priority).Not.Nullable();
            mapping.Map(x => x.operation).Not.Nullable();
            mapping.Map(x => x.Increasing).Not.Nullable();
            mapping.Map(x => x.Quantity).Not.Nullable();
        }
    }
}