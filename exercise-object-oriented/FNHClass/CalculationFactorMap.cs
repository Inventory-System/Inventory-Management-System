using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHClass
{
    class CalculationFactorMap:IAutoMappingOverride<CalculationFactor>
    {
        public void Override(AutoMapping<CalculationFactor> mapping)
        {
            mapping.Map(x => x.CalculatedPrice);
            mapping.References(x => x.Factor).Not.Nullable();
            mapping.HasOne(x => x.ProductDocument);
        }
    }
}
