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

using Galaxy.Base.Domain;
using Galaxy.Base.Data.Convertions;


namespace Sale.Data
{
    public class StoreConfiguration : DefaultAutomappingConfiguration
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
    public class FluentNHibernateHelper
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
            string ConnectionString = "Data Source=H-MORADI;Initial Catalog=Database1;User ID=sa;Password=sa123";

            var cfgi = new StoreConfiguration();

            var fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                    .ConnectionString(ConnectionString)
                    .ShowSql()
                );
            var configuration =
                fluentConfiguration.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<BaseClass>(cfgi).
                    //  IgnoreBase<Party>().
                    UseOverridesFromAssemblyOf<BaseClass>().Conventions.Add(typeof(CustomIdConvention)).Conventions.AddFromAssemblyOf<CustomForeignKeyConvention>).
                    Add(AutoMap.AssemblyOf<SaleProductDocument>(cfgi)));
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