using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using NHibernate;
using NHibernate.Linq;

namespace Galaxy.Base.Data.DAL
{
    public class Repository<T> : IRepository<T> where T : BaseClass
    {
        protected readonly ISession Session = null;
        protected readonly ITransaction Transaction = null;

        public Repository(ISession session, ITransaction transaction)
        {
            Session = session;
            Transaction = transaction;
        }

        public List<T> GetAll()
        {
            return Session.Query<T>().ToList();
        }

        public T GetById(Guid id )
        {
            return Session.Get<T>(id);
        }

        public object Find(Expression<Func<T, bool>> expression)
        {
            return Session.Query<T>().Where(expression).AsQueryable().ToList();
        }


        public void Add(T entity)
        {
            Session.Save(entity);
        }

        public void AddRange(List<T> entities)
        {
            foreach (T entity in entities)
            {
                Session.Save(entity);
            }
        }

        public void Remove(T entity)
        {
            Session.Delete(entity);
        }

        public void RemoveRange(List<T> entities)
        {
            foreach (T entity in entities)
            {
                Session.Delete(entity);
            }
        }
    }
}
