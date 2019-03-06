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
            Id( x => x.Id );
            Map( x => x.Code );
            Map( x => x.Name );
            References(x => x.measuerment);
        }
        
    }
}
