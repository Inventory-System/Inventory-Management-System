using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class PartyMap : IAutoMappingOverride<Party>
    {
        public void Override(AutoMapping<Party> mapping)
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