using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.Conventions
{
    class CustomPropertyConvention : IPropertyConvention, IReferenceConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Name == "Name")
            {
                instance.Not.Nullable();
                if (instance.EntityType == typeof(Product))
                    instance.Length(50);
            }
            if (instance.Name == "RegistrationNumber" || instance.Name == "PhoneNumber")
            {
                instance.Not.Nullable();
            }
        }
        public void Apply(IManyToOneInstance instance)
        {
            instance.Not.Nullable();
        }
    }
}
