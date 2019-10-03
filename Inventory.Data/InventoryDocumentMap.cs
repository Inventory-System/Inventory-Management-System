using Galaxy;
using FluentNHibernate.Automapping.Alterations;
using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class InventoryDocumentMap : IAutoMappingOverride<InventoryDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<InventoryDocument> mapping)
        {
            mapping.Map(c => c.DateIn).Column("InventoryDateIn");
           mapping.Map(c => c.DateOut).Column("InventoryDateOut");
           mapping.Map(c => c.EpxDate).Column("InventoryExpDate");
        }
    }
}
