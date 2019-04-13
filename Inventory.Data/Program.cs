using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Domain;
using Galaxy;
namespace Inventory.Data
{
    class Program
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
