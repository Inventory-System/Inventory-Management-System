using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_object_oriented;
using Inventory.HelperClass;
namespace Inventory
{
  public  class Program
    {
        static void Main(string[] args)
        {
            using (var session = InvenroryHelper.OpenSesseion())
            {
            }
            Console.ReadKey();
        }
    }
}
    
    
