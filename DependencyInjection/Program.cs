using System;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.ControllerInterfaces;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace DependencyInjection
{
    
    class Program
    {
        private static WindsorContainer _windsorContainer;
        public static void Main(string[] args)
        {
           
            // _windsorContainer = new WindsorContainer();

            // _windsorContainer.Install(FromAssembly.Containing<DependencyInstaller>());
      
            //var root =  _windsorContainer.Resolve<IMeasurementController>();
            

            //var measurmentCm = new Measurement { Code = 1, Name = "Kilogram" };
            //root.Create(measurmentCm);//
            //var product= new Product{Code=1, measurement=measurmentCm,Name="Youghart"};
            //root.Create(product);

            

            Console.ReadLine();
    



        }

    }
}
