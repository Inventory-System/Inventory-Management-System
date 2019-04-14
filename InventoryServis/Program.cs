using Galaxy.Base.Domain;
using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service
{
    public class Program
    {
        static void Main(string[] args)
        { var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
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
            DeleteProduct(product2);
            Console.ReadLine();
        }

        public static void InsertProduct(Product product)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(product);
                    transaction.Commit();
                }
            }
        }

        public static void UpdateProduct(Product product)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(product);
                    transaction.Commit();
                }
            }
        }
        public static void DeleteProduct(Product product)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(product);
                    transaction.Commit();
                }
            }
        }
        public static void PrintProducts(List<Product> products)
        {
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine( product.Name);
            }
        }
        public static void InsertMeasurement(Measurement measurement)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(measurement);
                    transaction.Commit();
                }
            }
        }
        public static void UpdateMeasurement(Measurement measurement)
        {
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(measurement);
                    transaction.Commit();
                }
            }
        }
        public static List<Measurement> GetMeasurements()
        {

            List<Measurement> measurements  = new List<Measurement>();
            using (var session = InventoryHelper.OpenSesseion())
            {
                using (var transaction = session.BeginTransaction())
                {
                    measurements = (List<Measurement>) session.CreateCriteria(typeof(Measurement)).List<Measurement>();
                }
            }

            return measurements;
        }

        public static void PrintMeasurement(List<Measurement> measurements)
        {
            Console.WriteLine("Measurements:");
            foreach (var measurement in measurements)
            {
                Console.WriteLine( measurement.Name);
      
            }
        }
    }
}
