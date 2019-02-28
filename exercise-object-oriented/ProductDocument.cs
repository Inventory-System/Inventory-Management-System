using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public  class ProductDocument : BaseClass
    {

        public ProductDocument()
        {
            // totalPrice = piece * orginalPrice;
            productId = product.id;
        }

        public int orginalPrice { get; set; }
        public int piece { get; set; }

        //   public int totalPrice{ get; set; }
        public int Profit { get; set; }
        public int SellingPrice { get; set; }
        public Product product { get; set; }
        private Guid productId;
    }
    public  abstract class ProductDocument<T> :ProductDocument where T: Document
    {
        public T TDocument;

    }
}
