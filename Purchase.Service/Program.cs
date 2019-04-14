using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using NHibernate;
using Purchase.Data;

namespace Purchase.Service
{
    class Program
    {
      
        static void Main(string[] args)
        {

            var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
            var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
            var product1 = new Product { Code = 33333, Name = "Meat", measurement = measurmentKg };
            var product2 = new Product { Code = 44444, Name = "Rice", measurement = measurmentKg };
            var product3 = new Product { Code = 55555, Name = "Textile", measurement = measurmentMeter };
            var product4 = new Product { Code = 66666, Name = "Pipe", measurement = measurmentMeter };

            InsertMeasurement(measurmentKg);
            InsertMeasurement(measurmentMeter);
            PrintMeasurement(GetMeasurements());

            InsertProduct(product1);
            InsertProduct(product2);
            InsertProduct(product3);
            InsertProduct(product4);
            PrintProducts(GetProducts());
            DeleteProduct(product3);
            Console.ReadLine();
        }

     
        static void InsertProduct(Product product)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(product);
                    transaction.Commit();
                }
            }
        }

        static void UpdateProduct(Product product)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(product);
                    transaction.Commit();
                }
            }
        }

        static List<Product> GetProducts()
        {
            

            List<Product> products = new List<Product>();
            // var products;
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    products = (List<Product>)session.CreateCriteria(typeof(Product)).List<Product>();

                    //  products = (List<Product>)produc;
                }
            }

            return products;
        }

        static void DeleteProduct(Product product)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(product);
                    transaction.Commit();
                    //  products = (List<Product>)produc;
                }
            }
        }

        public static void PrintProducts(List<Product> products)
        {
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine("\tName: " + product.Name);
                //Console.WriteLine("\tName: " + Product.);
                //Console.WriteLine("\tName: " + Product.Name);
                //Console.WriteLine("\tName: " + Product.Name);
            }
        }




        static void InsertMeasurement(Measurement measurement)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(measurement);
                    transaction.Commit();
                }
            }
        }

        static void UpdateMeasurement(Measurement measurement)
        {
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(measurement);
                    transaction.Commit();
                }
            }
        }

        static List<Measurement> GetMeasurements()
        {

            List<Measurement> measurements  = new List<Measurement>();
            // var products;
            using (var session = PurchaseFluentNHibernateHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    measurements = (List<Measurement>) session.CreateCriteria(typeof(Measurement)).List<Measurement>();

                  //  products = (List<Product>)produc;
                }
            }

            return measurements;
        }

        public static void PrintMeasurement(List<Measurement> measurements)
        {
            Console.WriteLine("Measurements:");
            foreach (var measurement in measurements)
            {
                Console.WriteLine("\tName: " + measurement.Name);
                //Console.WriteLine("\tName: " + Product.);
                //Console.WriteLine("\tName: " + Product.Name);
                //Console.WriteLine("\tName: " + Product.Name);
            }
        }
    }
}
