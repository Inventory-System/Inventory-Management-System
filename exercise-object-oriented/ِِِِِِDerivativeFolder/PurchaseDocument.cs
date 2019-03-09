using exercise_object_oriented.PurchaseFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class PurchaseDocument : Document<PurchaseProductDocument>
         
    {
        public  PurchaseDocument()
        {
         
            //party.posiontion = Position.Supplier;
            PurchaseDate = DateTime.Now;
      }

        public DateTime PurchaseDate { get; set; }

    }
}
 