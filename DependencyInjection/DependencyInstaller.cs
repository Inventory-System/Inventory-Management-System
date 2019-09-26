using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NHibernate;
using System.Reflection;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Service;
using Galaxy.Base.Domain;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using Castle.Core;
using FluentNHibernate.Automapping;
using Galaxy.Base.Controller;
using Galaxy.Base.Data.Convertions;
using Galaxy.Base.Data.Mapping;
using NHibernate.Tool.hbm2ddl;

namespace DependencyInjection
{
   public class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Kernel.ComponentRegistered += Kernel_ComponentRegistered;

            //Register all controllers
            container.Register(
                Component.For<ISessionFactory>().UsingFactoryMethod(CreateSessionFactory).LifeStyle.Singleton,
                Component.For<UnitOfWorkInterceptor>().LifeStyle.Transient,
                Classes.FromAssembly(Assembly.GetAssembly(typeof(MeasurementRepository))).InSameNamespaceAs(typeof(MeasurementRepository)).WithService.DefaultInterfaces().LifestyleTransient(),
                Classes.FromAssembly(Assembly.GetAssembly(typeof(MeasurementService))).InSameNamespaceAs(typeof(MeasurementService)).WithService.DefaultInterfaces().LifestyleTransient(),
                Classes.FromAssembly(Assembly.GetAssembly(typeof(MeasurementController))).InSameNamespaceAs(typeof(MeasurementController)).WithService.DefaultInterfaces().LifestyleTransient()

                );
        }



        public static ISessionFactory CreateSessionFactory()
        {

            var connStr = "Data Source=.;Initial Catalog=testInventoryDB;Integrated Security=True";
            ////Write your Connection String here....

            var cfgi = new StoreConfiguration();

            var fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(connStr)
                    .ShowSql()
                );
            var configuration =
                fluentConfiguration.Mappings(m =>
                    m.AutoMappings
                        .Add(AutoMap.AssemblyOf<BaseClass>(cfgi).UseOverridesFromAssemblyOf<BaseClass>().Conventions
                            .Add(typeof(CustomIdConvention))).Add(AutoMap.AssemblyOf<Document>(cfgi)));
            return configuration.ExposeConfiguration(cfg => { new SchemaUpdate(cfg).Execute(true, true); })
                .BuildSessionFactory();

        }


        void Kernel_ComponentRegistered(string key, Castle.MicroKernel.IHandler handler)
        {

            if (UnitOfWorkHelper.IsRepositoryClass(handler.ComponentModel.Implementation))
            {
                handler.ComponentModel.Interceptors.Add(new InterceptorReference(typeof(UnitOfWorkInterceptor)));
            }
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
