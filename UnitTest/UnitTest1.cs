using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using exercise_object_oriented.FNHFolder;
using exercise_object_oriented;
using FluentNHibernate;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var session = FluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
                    var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
                    var product1 = new Product { Code = 33333, Name = "Meat", Measuerment = measurmentKg };
                    var product2 = new Product { Code = 44444, Name = "Rice", Measuerment = measurmentKg };
                    var product3 = new Product { Code = 55555, Name = "Textile", Measuerment = measurmentMeter };
                    var product4 = new Product { Code = 55555, Name = "Pipe", Measuerment = measurmentMeter };

                    session.SaveOrUpdate(measurmentKg);
                    session.SaveOrUpdate(measurmentMeter);
                    session.SaveOrUpdate(product1);
                    session.SaveOrUpdate(product2);
                    session.SaveOrUpdate(product3);
                    session.SaveOrUpdate(product4);

                    transaction.Commit();
                }
            }
        }
    }
}
