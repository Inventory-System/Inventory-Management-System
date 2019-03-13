using exercise_object_oriented.FNHFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {

            }
            Console.ReadKey();
        }
    }
}
