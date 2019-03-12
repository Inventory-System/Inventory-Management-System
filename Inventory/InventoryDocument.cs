using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
        public class InventoryDocument : Document<InventoryProductDocument>
        {
            public virtual string InventoryName { set; get; }
            public virtual string InventoryCode { set; get; }

        }
}
