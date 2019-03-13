using FluentNHibernate.Automapping.Alterations;
using Inventory.InventoryCLass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MapingClass
{
    public class InventoryProductMap : IAutoMappingOverride<InventoryProductDocument>
        {
            public void Override(FluentNHibernate.Automapping.AutoMapping<InventoryProductDocument> mapping)
            {
                mapping.Map(c => c.EpxDate).Column("EpxDate");
                mapping.Map(c => c.DateIn).Column("DateIn");
                mapping.Map(c => c.DateOut).Column("DateOut");
                mapping.Table("Inventory");
            }
        }
    }

