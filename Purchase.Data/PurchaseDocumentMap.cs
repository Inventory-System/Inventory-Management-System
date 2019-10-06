
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping.Alterations;

namespace Purchase.Data
{
    public class PurchaseDocumentMap:IAutoMappingOverride<PurchaseDocument>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<PurchaseDocument> mapping)
        {
            mapping.Map(x => x.PurchaseDate);
            mapping.Map(x => x.Code);
            mapping.References(x => x.Party);
            mapping.Map(x => x.CreateDate);
            mapping.References(x => x.ProductDocumentsList);

        }
    }
}
