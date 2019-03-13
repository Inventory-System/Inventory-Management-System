using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_object_oriented;
using Sale.FluentNHibernateHelper;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var session = FluentNHibernateHelper)
            {

            }
            Console.ReadLine();
        }
    }
}
