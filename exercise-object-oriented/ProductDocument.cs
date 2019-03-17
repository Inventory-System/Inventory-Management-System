using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public abstract class ProductDocument : BaseClass
    {

        public ProductDocument()
        {
        }
        public virtual int OrginalPrice { get; set; }
        public virtual int Piece { get; set; }
        public virtual int Profit { get; set; }
        public virtual int SellingPrice { get; set; }
        public virtual Product Product { get; set; }

      
    }
    public  abstract class ProductDocument<T> :ProductDocument where T: Document
    {
        public virtual T Document { get; set; }

    }
}
