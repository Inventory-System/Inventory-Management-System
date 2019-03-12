using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.Conventions
{
    class CustomPropertyConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Name == "RegistrationNumber" || instance.Name == "PhoneNumber")
            {
                instance.Not.Nullable();
            }
        }

    }
}