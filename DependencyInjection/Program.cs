using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Galaxy.Base.Service;
using Galaxy.Base.Domain.ServiceInterfaces;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain;

namespace DependencyInjection
{
    
    class Program
    {
        private static WindsorContainer _windsorContainer;
        public static void Main(string[] args)
        {
            InitializeWindsor();
            _windsorContainer.Register(Component.For(typeof(IService<>)).ImplementedBy(typeof(Service<>)).LifestyleTransient());
            _windsorContainer.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)));

            _windsorContainer.Register(Component.For(typeof(IUnitOfWork)).ImplementedBy(typeof(UnitOfWork)));
          //  _windsorContainer.Resolve<ProductService>();

            

        }

        protected void Application_End()
        {
            if (_windsorContainer != null)
            {
                _windsorContainer.Dispose();
            }
        }

        private static void InitializeWindsor()
        {
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.This());

           // ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windsorContainer.Kernel));
        }
    }
}
