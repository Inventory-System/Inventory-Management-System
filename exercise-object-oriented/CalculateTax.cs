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
                       Price += tmp;  
                   }
                   else
                   {
                       Price -= tmp;
                   }
                   break;
               case Operation.Unit:
                   if (tax.Increasing == true)
                   {
                       Price += tax.Quantity;
                   }
                   else 
                   {
                       Price -= tax.Quantity;
                   }
                   break;
               case Operation.Amount:
                   if (tax.Increasing == true) 
                   {
                       /****************************************************************************************************/
                   }
                   else 
                   {
                       /****************************************************************************************************/
                   }
                   break;
           }
          
           return  Price;
       }
    }
}
