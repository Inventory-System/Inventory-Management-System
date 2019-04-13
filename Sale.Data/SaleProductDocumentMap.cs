
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sale.Data
{
    class SaleProductDocumentMap : IAutoMappingOverride<SaleProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<SaleProductDocument> mapping)
        {
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Piece);
            mapping.Map(x => x.product);
           // mapping.HasOne(x => x.SellingPrice);

        }
    }
}
