using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace exercise_object_oriented.Mapping
{
    class ProductMap: ClassMap<Product>
    {
        public ProductMap() 
        {
            Map( x => x.Name );
            References(x => x.measuerment);
        }
        
    }
}
