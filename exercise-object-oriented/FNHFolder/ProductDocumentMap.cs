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
            Id(x => x.Id);
            Map(x => x.Code);
            Map(x => x.OrginalPrice);
            Map(x => x.Piece);
            Map(x => x.Profit);
            Map(x => x.SellingPrice);
            References(x => x.product);
          //  DiscriminateSubClassesOnColumn("FieldType22");
            //  References(x => x.document);
            // HasOne(x => x.TDocument);
            //References(x => x.TDocument);
        }
    }

    //    class ProductDocument2Map : SubclassMap<ProductDocument<Document>>
    //    {
    //        public ProductDocument2Map()
    //        {
    //            DiscriminatorValue("dfssss");
    //            References(x => x.document);
    //    //        Id(x => x.Id);
    //    //        Map(x => x.Code);
    //    //        Map(x => x.OrginalPrice);
    //    //        Map(x => x.Piece);
    //    //        Map(x => x.Profit);
    //    //        Map(x => x.SellingPrice);
    //    //        References(x => x.product);
    //           // HasOne(x => x.TDocument);
    //        }
    //    }
//    }
}
