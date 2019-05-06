using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Utils;
using Galaxy.Base.Data.Mapping;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain;
using NHibernate;

namespace Galaxy.Base.Data.DAL
{
    public class UnitOfWork : IUnitOfWork 
    {
    
        public static UnitOfWork Current
    {
        get { return _current; }
        set { _current = value; }
    }
    [ThreadStatic]
    private static UnitOfWork _current;

    /// <summary>
    /// Gets Nhibernate session object to perform queries.
    /// </summary>
    public ISession Session { get; private set; }

    /// <summary>
    /// Reference to the session factory.
    /// </summary>
    private readonly ISessionFactory _sessionFactory;

    /// <summary>
    /// Reference to the currently running transcation.
    /// </summary>
    private ITransaction _transaction;

    /// <summary>
    /// Creates a new instance of NhUnitOfWork.
    /// </summary>
    /// <param name="sessionFactory"></param>
    public UnitOfWork(ISessionFactory sessionFactory)
    {
        _sessionFactory = sessionFactory;
    }

    /// <summary>
    /// Opens database connection and begins transaction.
    /// </summary>
    public void BeginTransaction()
    {
        Session = _sessionFactory.OpenSession();
        _transaction = Session.BeginTransaction();
    }

    /// <summary>
    /// Commits transaction and closes database connection.
    /// </summary>
    public void Commit()
    {
        try
        {
            _transaction.Commit();
        }
        finally
        {
            Session.Close();                
        }
    }

    /// <summary>
    /// Rollbacks transaction and closes database connection.
    /// </summary>
    public void Rollback()
    {
        try
        {
            _transaction.Rollback();
        }
        finally
        {
            Session.Close();                
        }
    }
    }
}
