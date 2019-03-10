using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.Conventions
{
    class MyPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Type.Name == "Code")
                instance.CustomType<Int64>();
        }
    }
}