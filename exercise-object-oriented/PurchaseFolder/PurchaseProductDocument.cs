using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented.PurchaseFolder
{
    public class PurchaseProductDocument: ProductDocument<PurchaseDocument>
    {
        Party supplier;
    }
}
