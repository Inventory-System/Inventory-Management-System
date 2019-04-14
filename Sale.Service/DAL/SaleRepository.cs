using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using NHibernate;
using NHibernate.Linq;


namespace Sale.Service.DAL
{
   public class SaleRepository<T>:ISaleRepository<T>,IDisposable
    {
        private ISession _session;
        private bool _disposed = false;

       public SaleRepository()
       {
           _session = SingletonCore.SessionFactory.OpenSession();
           BeginTransaction();
           ~Repository()
           {
               Dispose(false);
           }
       public T Get(object key)
         {
            if (!isSessionSafe) return default(T);
            return _session.Get<T>(key);
         }
       }
    }
}
