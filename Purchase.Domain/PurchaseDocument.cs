
using Galaxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;


namespace Purchase
{
    public class PurchaseDocument : Document<PurchaseProductDocument>
         
    {
        public  PurchaseDocument()
        {
         
            //party.posiontion = Position.Supplier;
            PurchaseDate = DateTime.Now;
      }

        public virtual DateTime PurchaseDate { get; set; }

    }
}
 