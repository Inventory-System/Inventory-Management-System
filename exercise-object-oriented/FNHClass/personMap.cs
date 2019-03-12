using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.FNHClass
{
    class personMap : IAutoMappingOverride<Person>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Person> mapping)
        {
            mapping.Map(x => x.NationalIdentityNumber).Not.Nullable();
            mapping.Map(x => x.FirstName).Not.Nullable().Length(50);
            mapping.Map(x => x.LastName).Not.Nullable().Length(50);
        }
    }
}
