using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.Mapping
{
    public class ProductMap : IAutoMappingOverride<Product>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Product> mapping)
        {
            mapping.Map(x => x.Name).Not.Nullable().Length(50);
            mapping.References(x => x.measuerment).Not.Nullable();
        }
    }
}
