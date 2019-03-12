using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_object_oriented;
using FluentNHibernate.Mapping;
using Inventory.InventoryCLass;
namespace Inventory.MapingClass
{
    public class InventoryMaping : ClassMap<InventoryDocument>
    {
        public InventoryMaping()
        {
            Map(c => c.CreateDate).Column("CreateDate");
            Map(c => c.DocumentsList).Column("DocumentsList");
            Map(c => c.InventoryName).Column("InventoryName");
            Table("Inventory");
        }
    }
}
