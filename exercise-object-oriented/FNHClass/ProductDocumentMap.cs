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
<<<<<<< HEAD:exercise-object-oriented/FNHClass/ProductDocumentMap.cs
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Profit);
            mapping.Map(x => x.SellingPrice);
            mapping.References(x => x.product);
            //  References(x => x.document);
            // HasOne(x => x.TDocument);
            //References(x => x.TDocument);
=======
            Map(x => x.OrginalPrice);
            Map(x => x.Piece);
            Map(x => x.Profit);
            Map(x => x.SellingPrice);
            References(x => x.product);
>>>>>>> a1aef27290c18cfaac97b09830285f0c0e44a1cf:exercise-object-oriented/FNHFolder/ProductDocumentMap.cs
        }
    }
}
