using System;
using FluentNHibernate.Conventions;

namespace Galaxy.Base.Data.Convertions
{
    public class CustomForeignKeyConvention : ForeignKeyConvention
    {
        protected override string GetKeyName(FluentNHibernate.Member property, Type type)
        {
            if (property == null)
                return "Id";  // many-to-many, one-to-many, join
            else return  property.Name.Substring(0,1).ToUpper()+property.Name.Substring(1) + "_Id";
        }
    }
    
}