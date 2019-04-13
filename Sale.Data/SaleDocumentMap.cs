using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;


namespace Sale
{
  public  class SaleDocumentMap : IAutoMappingOverride<SaleDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<SaleDocument> mapping)
        {
            mapping.Map(x => x.CreateDate).Length(20).Not.Nullable();
            mapping.Map(x => x.SaleDate).Length(20).Not.Nullable();
            mapping.References(x => x.Party);
            mapping.References(x => x.ProductDocumentsList);
            
        }
    }
}
