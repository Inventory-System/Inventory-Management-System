using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.FNHClass
{
    public class PartyMap:IAutoMappingOverride<Party>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Party> mapping)
        {
            mapping.Map(x => x.RegistrationNumber).Not.Nullable();
            mapping.Map(x => x.RegistrationDate);
            mapping.Map(x => x.Address);
            mapping.Map(x => x.PhoneNumber).Not.Nullable();
            mapping.Map(x => x.EmailAddress);
            mapping.Map(x => x.Posiontion);
        }
    }
}
