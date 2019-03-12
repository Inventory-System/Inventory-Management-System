using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.Mapping
{
    class SaleDocumentMap : IAutoMappingOverride<SaleDocumentMap>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Measurement> mapping)
        {
            mapping.Map(x => x.Name).Length(20).Not.Nullable();
            mapping.Map(x => x.Code).Length(20).Not.Nullable();
           
        }
    }
}
