using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Galaxy.Base.Data.Convertions
{
    public class CustomIdConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column("Id");
            instance.GeneratedBy.Assigned();

        }
    }
}