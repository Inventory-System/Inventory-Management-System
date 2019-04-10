using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHClass
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