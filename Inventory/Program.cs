<<<<<<< HEAD
﻿using exercise_object_oriented.FNHFolder;
//using Inventory.HelperClass;
using System;
=======
﻿using System;
>>>>>>> a1aef27290c18cfaac97b09830285f0c0e44a1cf
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = FluentNHibernateHelper.OpenSesseion())
            {

=======
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
>>>>>>> a1aef27290c18cfaac97b09830285f0c0e44a1cf
            }
            Console.ReadKey();
        }
    }
}
<<<<<<< HEAD
=======
    
    
>>>>>>> a1aef27290c18cfaac97b09830285f0c0e44a1cf
