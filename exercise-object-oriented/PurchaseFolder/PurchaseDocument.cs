using exercise_object_oriented.PurchaseFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    class PurchaseDocument : Document<PurchaseProductDocument>
         
    {
        public  PurchaseDocument()
        {
           // supplier.posiontion = Position.Supplier;
           // employee.posiontion = Position.Employee;
            purchaseDate = DateTime.Now;
      }

        public DateTime purchaseDate { get; set; }
        Party supplier;

    }
}
 