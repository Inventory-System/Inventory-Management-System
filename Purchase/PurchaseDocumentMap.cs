using exercise_object_oriented;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase
{
    public class PurchaseDocumentMap:IAutoMappingOverride<PurchaseDocument>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<PurchaseDocument> mapping)
        {
            mapping.Map(x=>x.CreateDate);
            mapping.References(x => x.party).Not.Nullable();
            mapping.Map(x => x.PurchaseDate);
            mapping.HasMany(x => x.ProductDocumentsList);

        }
    }
}
