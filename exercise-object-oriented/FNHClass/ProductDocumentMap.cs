using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHFolder
{
    class ProductDocumentMap : IAutoMappingOverride<ProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<ProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Profit);
            mapping.Map(x => x.SellingPrice);
            mapping.References(x => x.product);
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
