using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.FNHClass
{
    public class CompanyMap:IAutoMappingOverride<Company>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Company> mapping)
        {
            mapping.Map(x => x.CompanyID).Not.Nullable();
            mapping.Map(x => x.CompanyName ).Not.Nullable().Length(50);
            mapping.Map(x => x.Industry ).Length(50);
            mapping.Map(x => x.FaxNumber );
            mapping.Map(x => x.Website).Length(100);
        }
    }
}
