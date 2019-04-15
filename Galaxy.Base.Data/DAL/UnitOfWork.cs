using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Utils;
using Galaxy.Base.Data.Mapping;
using Galaxy.Base.Domain.DAL;
using NHibernate;

namespace Galaxy.Base.Data.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public ISession Session { get; private set; }
        public ITransaction Transaction { get; private set; }
        public IProductRepository ProductRepository { get; private set; }
        public IMeasurementRepository MeasurementRepository { get; private set; }
        public UnitOfWork()
        {
            Session = FluentNHibernateHelper.OpenSesseion();
            BeginTransaction();
            ProductRepository = new ProductRepository(Session, Transaction);
            MeasurementRepository = new MeasurementRepository(Session, Transaction);
        }


        public void BeginTransaction()
        {
            Transaction = Session.BeginTransaction();
        }

        public void CommitTransaction()
        {
            Transaction.Commit();
        }

        public void RollbackTransaction()
        {
            Transaction.Rollback();
            CloseTransaction();
            CloseSession();
        }

        public void CloseTransaction()
        {
            Transaction.Dispose();
            Transaction = null;
        }

        public void CloseSession()
        {
            Session.Close();
            Session.Dispose();
            Session = null;
        }

        public void Dispose()
        {
            if (Session != null) Session.Dispose();
            if (Transaction != null) Transaction.Dispose();
        }
    }
}
