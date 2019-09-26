using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using DependencyInjection;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.ControllerInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Galaxy.Base.UnitTest
{
    [TestClass]
    public class DependencyUnitTest
    {
        private WindsorContainer windsorContainer;
        [TestMethod]
        public void TestDependency()
        {
            var _windsorContainer = new WindsorContainer();

            _windsorContainer.Install(FromAssembly.Containing<DependencyInstaller>());

            var measurementController = _windsorContainer.Resolve<IMeasurementController>();
            var productController = _windsorContainer.Resolve<IProductController>();

            var measurmentCm = new Measurement { Code = 2, Name = "Number" };
            measurementController.Create(measurmentCm);//

            var product = new Product { Code = 1, measurement = measurmentCm, Name = "NoteBook" };
            productController.Create(product);

        }
    }
}
