using exercise_object_oriented;
using FluentNHibernate.Automapping.Alterations;
using Inventory.InventoryCLass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MapingClass
{
    public class InventoryMap : IAutoMappingOverride<InventoryDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<InventoryDocument> mapping)
        {
            mapping.Map(c => c.InventoryCode).Column("InventoryCode");
           mapping.Map(c => c.InventoryName).Column("InventoryName");
           mapping.Table("Inventory");
        }
    }
}
