using exercise_object_oriented;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale
{
    class SaleProductDocumentMap : IAutoMappingOverride<SaleProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<SaleProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.Product);
            mapping.HasOne(x => x.SellingPrice);
        }
    }
}
