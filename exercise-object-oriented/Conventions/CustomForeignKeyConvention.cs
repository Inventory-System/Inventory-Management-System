using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.Conventions
{
    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(FluentNHibernate.Member property, Type type)
        {
            if (property == null)
                return "Id";  // many-to-many, one-to-many, join
            return  property.Name.Substring(0,1).ToUpper()+property.Name.Substring(1) + "_Id";
        }
    }
}