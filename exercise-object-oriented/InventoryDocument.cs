using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
        public class InventoryDocument : Document<InventoryPorodactDocument>
        {
            public string InventoryName { set; get; }
            public string InventoryCod { set; get; }

        }
}
