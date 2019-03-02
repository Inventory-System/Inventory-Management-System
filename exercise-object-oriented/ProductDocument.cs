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
            productId = product.Id;
        }

        public int OrginalPrice { get; set; }
        public int Piece { get; set; }

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
