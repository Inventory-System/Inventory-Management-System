using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.FNHFolder
{
   public class BasseIdConvention : IIdConvention
    {
       public void Apply(IIdentityInstance instanse)
       {
           instanse.Column(instanse.EntityType.Name+"Id");
           instanse.GeneratedBy.Guid();
       } 
    }
   public class BasseCodeConvention : IPropertyConvention
   {
           public void Apply(IPropertyInstance instance)
           {
               if (instance.Type.Name == "Code")
                   instance.CustomType<Int64>();
           }
       }
   }

