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
    public class ProductDocumentMap : IAutoMappingOverride<ProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<ProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Profit);
            mapping.Map(x => x.SellingPrice);
            mapping.References(x => x.Product).Not.Nullable();

        }
    }
    public class GenericProductDocumentMap : IAutoMappingOverride<ProductDocument<Document>>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<ProductDocument<Document>> mapping)
        {
             mapping.HasOne(x => x.Document );
        }

    }
}
