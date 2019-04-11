
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase
{
    class PurchaseProductDocumentMap:IAutoMappingOverride<PurchaseProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<PurchaseProductDocument> mapping)
        {

        }
    }
}
