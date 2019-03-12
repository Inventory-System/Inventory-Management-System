using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class InventoryProductDocument:ProductDocument<InventoryDocument>
    {
        public virtual DateTime EpxDate { set; get; }
        public virtual DateTime DateIn { set; get; }
        public virtual DateTime DateOut { set; get; }
        public virtual List<ProductDocument> ListOfPrdsuct { set; get; }
 

    }
}
