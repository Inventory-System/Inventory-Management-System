﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class PersonMap : IAutoMappingOverride<Person>
    {
        public void Override(AutoMapping<Person> mapping)
        {
            mapping.Map(x => x.NationalIdentityNumber).Not.Nullable();
            mapping.Map(x => x.FirstName).Not.Nullable().Length(50);
            mapping.Map(x => x.LastName).Not.Nullable().Length(50);
        }
    }
}