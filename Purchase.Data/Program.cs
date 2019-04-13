using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;

namespace Purchase.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
                    var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
                    var product1 = new Product { Code = 33333, Name = "Meat", measurement = measurmentKg };
                    var product2 = new Product { Code = 44444, Name = "Rice", measurement = measurmentKg };
                    var product3 = new Product { Code = 55555, Name = "Textile", measurement = measurmentMeter };
                    var product4 = new Product { Code = 55555, Name = "Pipe", measurement = measurmentMeter };

                    session.SaveOrUpdate(measurmentKg);
                    session.SaveOrUpdate(measurmentMeter);
                    session.SaveOrUpdate(product1);
                    session.SaveOrUpdate(product2);
                    session.SaveOrUpdate(product3);
                    session.SaveOrUpdate(product4);

                    transaction.Commit();
                }
            }
            Console.ReadLine();
        }
    }
}
