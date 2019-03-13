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
using exercise_object_oriented.Conventions;
using Inventory.InventoryCLass;


namespace exercise_object_oriented.FNHFolder
{
    public class InventoryConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            if (type.IsSubclassOf(typeof(BaseClass)))
            {
                return true;
            }
            return false;
        }
    }
    public class InventoryHelper
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
        public static ISessionFactory CreatSessionFactory()
        {
            string ConnectionString = "Data Source=.;Initial Catalog=Inventory;User ID=sa;Password=sa123";

            var cfgi = new InventoryConfiguration();

            var fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(ConnectionString)
                    .ShowSql()
                );
            var configuration =
                fluentConfiguration.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<BaseClass>(cfgi).
                    //  IgnoreBase<Party>().
                    UseOverridesFromAssemblyOf<BaseClass>().Conventions.Add(typeof(CustomIdConvention))).
                    Add(AutoMap.AssemblyOf<InventoryDocument>(cfgi)));
            _sessionFactory = configuration.ExposeConfiguration(cfg =>
            {
                new SchemaUpdate(cfg).Execute(false, false);
                new SchemaExport(cfg).Create(true, true);
            })
                 .BuildSessionFactory();
            return _sessionFactory;
        }

        public static ISession OpenSesseion()
        {
            return SessionFactory.OpenSession();
        }
    }
}
//There is already an object named 'Party' in the database.