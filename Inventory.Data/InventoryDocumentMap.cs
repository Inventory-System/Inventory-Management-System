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
            mapping.Map(c => c.InventoryCode).Column("InventoryCode");
           mapping.Map(c => c.InventoryName).Column("InventoryName");
           mapping.Table("Inventory");
        }
    }
}
