using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NHibernate;
using System.Reflection;
using Castle.Core;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Service;
using Galaxy.Base.Domain;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;

namespace DependencyInjection
{
    class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;

            //Register all controllers
            container.Register(

                //Nhibernate session factory
                Component.For<ISessionFactory>().UsingFactoryMethod(CreateNhSessionFactory).LifeStyle.Singleton,

                //Unitofwork interceptor
                Component.For<UnitOfWorkInterceptor>().LifeStyle.Transient,

                //All repoistories
                Classes.FromAssembly(Assembly.GetAssembly(typeof(Repository<>))).InSameNamespaceAs(typeof(Repository<>)).WithService.DefaultInterfaces().LifestyleTransient(),

                //All services
                Classes.FromAssembly(Assembly.GetAssembly(typeof(Service<>))).InSameNamespaceAs(typeof(Service<>)).WithService.DefaultInterfaces().LifestyleTransient()

                //All MVC controllers
             //   Classes.FromThisAssembly().BasedOn<IController>().LifestyleTransient()

                );
        }

        /// <summary>
        /// Creates NHibernate Session Factory.
        /// </summary>
        /// <returns>NHibernate Session Factory</returns>
        private static ISessionFactory CreateNhSessionFactory()
        {
            var connStr = "Data Source=T-SAFARI;Initial Catalog=testInventoryDB;User ID=sa;Password=s@123456";
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStr))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(BaseClass))))
                .BuildSessionFactory();
        }

        void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {
            //Intercept all methods of all repositories.
            if (UnitOfWorkHelper.IsRepositoryClass(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(UnitOfWorkInterceptor)));
            }

            //Intercept all methods of classes those have at least one method that has UnitOfWork attribute.
            foreach (var method in handler.ComponentModel.Implementation.GetMethods())
            {
                if (UnitOfWorkHelper.HasUnitOfWorkAttribute(method))
                {
                    handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(UnitOfWorkInterceptor)));
                    return;
                }
            }
        }
    }
}
