using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public abstract class ProductDocument : BaseClass
    {

        public virtual int OrginalPrice { get; set; }
        public virtual int Piece { get; set; }
        public virtual int Profit { get; set; }
        public virtual float SellingPrice { get; set; }
        public virtual Product product { get; set; }

        public virtual Factor calculateTax { get; set; }

      

      
    }
    public  abstract class ProductDocument<T> :ProductDocument where T: Document
    {
        public virtual T Document { get; set; }


        public decimal Calculate(decimal Price, Factor factor)
        {
            decimal tmp;

            switch (factor.operation)
            {
                case Operation.Percentage:

                    tmp = ((factor.Quantity / 100) * Price);
                    if (factor.Increasing == true)
                    {
                        Price += tmp;
                    }
                    else
                    {
                        Price -= tmp;
                    }
                    break;
                case Operation.Unit:
                    if (factor.Increasing == true)
                    {
                        Price += factor.Quantity;
                    }
                    else
                    {
                        Price -= factor.Quantity;
                    }
                    break;
                case Operation.Amount:
                    if (factor.Increasing == true)
                    {
                        /****************************************************************************************************/
                        //
                    }
                    else
                    {
                        /****************************************************************************************************/
                        //
                    }
                    break;
                default:
                    break;
                  
            }

            return Price;
        }
    }
}
