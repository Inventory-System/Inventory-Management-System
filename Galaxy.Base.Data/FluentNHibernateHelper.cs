﻿namespace exercise_object_oriented.FNHFolder
{
    //public class StoreConfiguration : DefaultAutomappingConfiguration
    //{
    //    public override bool ShouldMap(Type type)
    //    {
    //        if(type.IsSubclassOf(typeof(BaseClass)))
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //}
    //public class FluentNHibernateHelper
    //{

    //    private static ISessionFactory _sessionFactory;
    //    private static ISessionFactory SessionFactory
    //    {
    //        get
    //        {
    //            if (_sessionFactory == null)
    //                CreatSessionFactory();
    //            return _sessionFactory;
    //        }
    //    }
    //    public static ISessionFactory CreatSessionFactory() 
    //    {
    //        string ConnectionString = "Data Source=T-SAFARI;Initial Catalog=testInventoryDB;User ID=sa;Password=s@123456";

    //        var cfgi = new StoreConfiguration();

    //        var fluentConfiguration = Fluently.Configure()
    //            .Database(MsSqlConfiguration.MsSql2012
    //                .ConnectionString(ConnectionString)
    //                .ShowSql()
    //            );
    //        var configuration =
    //            fluentConfiguration.Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<Person>(cfgi).
    //                IgnoreBase<Party>().
    //                UseOverridesFromAssemblyOf<ProductDocumentMap>().Conventions.Add(typeof(CustomIdConvention))));
    //       _sessionFactory = configuration.ExposeConfiguration(cfg =>
    //            {
    //                new SchemaUpdate(cfg).Execute(false, false);
    //                new SchemaExport(cfg)
    //                    .Create(true, true);
    //            })
    //            .BuildSessionFactory();
    //        return _sessionFactory;
    //    }

    //    public static ISession OpenSesseion()
    //    {
    //        return SessionFactory.OpenSession();
    //    }
    //}
}