using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
   public class CalculateTax
    {
       List<Tax> TaxList { get; set; }
       public float Calculate(float Price, Tax tax)
       {
           
           float tmp;

           switch (tax.operation)
           {
               case Operation.Percentage:

                   tmp = ((tax.Quantity / 100) * Price);
                   if (tax.Increasing == true)
                   {
                       Price = Price + (tmp * Price);  
                   }
                   else
                   {
                       Price = Price - (tmp * Price);
                   }
                   break;
           }
           return  Price;
       }
    }
}
