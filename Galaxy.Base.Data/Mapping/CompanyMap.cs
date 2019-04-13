using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Data.Mapping
{
    public class CompanyMap : IAutoMappingOverride<Company>
    {
        public void Override(AutoMapping<Company> mapping)
        {
            mapping.Map(x => x.CompanyID).Not.Nullable().Column("Company_Id");
            mapping.Map(x => x.CompanyName).Not.Nullable().Length(50);
            mapping.Map(x => x.Industry).Length(50);
            mapping.Map(x => x.FaxNumber);
            mapping.Map(x => x.Website).Length(100);
        }
    }
}