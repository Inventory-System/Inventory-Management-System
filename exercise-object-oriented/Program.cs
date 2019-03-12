using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using exercise_object_oriented;

namespace exercise_object_oriented
{
    class Program
    {
        static void Main(string[] args)
        {

            //using (var session = FluentNHibernateHelper.OpenSesseion())
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {
            //        var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
            //        var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
            //        var product1 = new Product { Code = 33333, Name = "Meat", measuerment = measurmentKg };
            //        var product2 = new Product { Code = 44444, Name = "Rice", measuerment = measurmentKg };
            //        var product3 = new Product { Code = 55555, Name = "Textile", measuerment = measurmentMeter };
            //        var product4 = new Product { Code = 55555, Name = "Pipe", measuerment = measurmentMeter };

            //        session.SaveOrUpdate(measurmentKg);
            //        session.SaveOrUpdate(measurmentMeter);
            //        session.SaveOrUpdate(product1);
            //        session.SaveOrUpdate(product2);
            //        session.SaveOrUpdate(product3);
            //        session.SaveOrUpdate(product4);

            //        transaction.Commit();
            //    }
            //}
            Console.ReadLine();
        }
    }
}
