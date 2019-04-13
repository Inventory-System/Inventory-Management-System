using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = FluentNHibernateHelper.OpenSesseion()) ;
        }
    }
}
