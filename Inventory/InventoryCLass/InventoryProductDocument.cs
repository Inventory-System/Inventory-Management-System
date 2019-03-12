using exercise_object_oriented;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.InventoryCLass
{
    public class InventoryProductDocument : ProductDocument<InventoryDocument>
    {
        public DateTime EpxDate { set; get; }
        public DateTime DateIn { set; get; }
        public DateTime DateOut { set; get; }
    }
}
