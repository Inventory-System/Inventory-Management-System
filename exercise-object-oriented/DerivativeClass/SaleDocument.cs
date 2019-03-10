using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
  public  class SaleDocument:Document<SaleProductDocument>
    {
        public SaleDocument()
        {
            SaleDate = DateTime.Now;
        }
        public DateTime SaleDate { get; set; }
        Party customer;
    }
}
