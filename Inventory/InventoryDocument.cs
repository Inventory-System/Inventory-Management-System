using exercise_object_oriented;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.InventoryCLass;
namespace Inventory.InventoryCLass
{
    public class InventoryDocument : Document<InventoryProductDocument>
    {
        public string InventoryName { set; get; }
        public string InventoryCode { set; get; }
        public List<ProductDocument> DocumentsList { set; get; }
    }
}
