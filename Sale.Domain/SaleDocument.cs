
using Galaxy.Base.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Sale
{
  public  class SaleDocument:Document<SaleProductDocument>
    {
        public SaleDocument()
        {
            SaleDate = DateTime.Now;
        }
        public virtual DateTime SaleDate { get; set; }
        Party  customer;
    }
}
