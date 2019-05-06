using System;
using DependencyInjection;

using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Galaxy.Base.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var measurmentCm = new Measurement { Code = 5555, Name = "test2" };
      //      var product1 = new Product { Code = 8888, Name = "Union"};
            var registerService = WebConfiguration.RegisterProductService();
            registerService.Create(measurmentCm);
         //   registerService.Create(product1);
          //  var registerMeasurementService = WebConfiguration.
            
          

            //using (var UnitOfWork = new UnitOfWork())
            //{
            //    var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
            //    var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
            //    var product1 = new Product { Code = 33333, Name = "Meat", measurement = measurmentKg };
            //    var product2 = new Product { Code = 44444, Name = "Rice", measurement = measurmentKg };
            //    var product3 = new Product { Code = 55555, Name = "Textile", measurement = measurmentMeter };
            //    var product4 = new Product { Code = 66666, Name = "Pipe", measurement = measurmentMeter };
            //    UnitOfWork.MeasurementRepository.Add(measurmentKg);
            //    UnitOfWork.MeasurementRepository.Add(measurmentMeter);
            //    UnitOfWork.ProductRepository.Add(product1);
            //    UnitOfWork.ProductRepository.Add(product4);
            //    //Guid x = new Guid("0893CAAF-8F61-47EC-8D9A-F06282FCCB5E");
            //    //var product5 = new Product { Code = 77777, Name = "Textilenew", measurement = measurmentMeter };
            //    //var product6 = new Product { Id = x, Code = 66666, Name = "PipeChanged2", measurement = measurmentMeter };
            //    //UnitOfWork.ProductRepository.Update(product5);
            //    //UnitOfWork.ProductRepository.Update(product6);
            //    //UnitOfWork.CommitTransaction();
            //}
        }
        
    }
}
