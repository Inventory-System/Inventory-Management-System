using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using exercise_object_oriented.FNHFolder;

namespace exercise_object_oriented
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
