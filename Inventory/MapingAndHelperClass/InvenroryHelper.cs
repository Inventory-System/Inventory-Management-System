using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;
using exercise_object_oriented;
using exercise_object_oriented.FNHFolder;
using Inventory.InventoryCLass;

namespace Inventory.HelperClass
{
    public class InventoryConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {

            if (type.BaseType != null && type.BaseType == typeof(BaseClass))
            {
                return true;
            }
            return false;
        }
    }
    public class InvenroryHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    CreatSessionFactory();
                return _sessionFactory;
            }
        }
        //private static  string connectionString = "Data Source=T-SAFARI;Initial Catalog=SecTestDB;User ID=sa;Password=s@123456";
        private static ISessionFactory CreatSessionFactory() 
        {
            string ConnectionString = "Data Source=.;Initial Catalog=Inventory;User ID=sa;Password=sa123";
            var cfgi = new StoreConfiguration();
            var fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(ConnectionString)
                    .ShowSql()
                );
            var configuration =
                fluentConfiguration.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<InventoryDocument>(cfgi).
                    UseOverridesFromAssemblyOf<InventoryDocument>().Conventions.Add(typeof(BasseIdConvention))));
            var buildSessionFactory = configuration.ExposeConfiguration(cfg =>
                {
                    new SchemaUpdate(cfg).Execute(false, false);
                    new SchemaExport(cfg).Create(true, true);
                })
                .BuildSessionFactory();
            _sessionFactory = buildSessionFactory;
            return _sessionFactory;
        }
        public static ISession OpenSesseion()
        {
            return SessionFactory.OpenSession();
        }
    }
}
