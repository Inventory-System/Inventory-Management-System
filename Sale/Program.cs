using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_object_oriented;
using exercise_object_oriented.FNHFolder;

namespace Sale
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var session = FluentNHibernateHelper.OpenSesseion())
            {

            }
            Console.ReadLine();
        }
    }
}
