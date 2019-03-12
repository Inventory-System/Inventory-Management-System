using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using FluentNHibernate.Mapping;

namespace exercise_object_oriented.FNHFolder
{
    class ProductDocumentMap : ClassMap<ProductDocument>
    {
        public ProductDocumentMap()
        {
            Map(x => x.OrginalPrice);
            Map(x => x.Piece);
            Map(x => x.Profit);
            Map(x => x.SellingPrice);
            References(x => x.product);
        }
    }
}
