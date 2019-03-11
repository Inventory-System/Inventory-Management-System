using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.Conventions
{
    public class CustomIdConvention : IIdConvention
    {
        public void Apply(IIdentityInstance instanse)
        {
            instanse.Column("Id");
            instanse.GeneratedBy.Guid();
        }
    }
}