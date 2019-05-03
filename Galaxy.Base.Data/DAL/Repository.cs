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


        public Repository() 
        {
        
        }
       
        protected ISession Session { get { return UnitOfWork.Current.Session; } }

        public void Create(T entity)
        {
            Session.Save(entity);
        }

        public List<T> ReadAll()
        {
            return Session.Query<T>().ToList();
        }

        public T Read(Guid id )
        {
            return Session.Get<T>(id);
        }

        public void Delete(Guid id)
        {
            Session.Delete(id);
        }


        //public object Find(Expression<Func<T, bool>> expression)
        //{
        //    return Session.Query<T>().Where(expression).AsQueryable().ToList();
        //}


 
        //public void AddRange(List<T> entities)
        //{
        //    foreach (T entity in entities)
        //    {
        //        Session.Save(entity);
        //    }
        //}

       
        //public void DeleteRange(List<T> entities)
        //{
        //    foreach (T entity in entities)
        //    {
        //        Session.Delete(entity);
        //    }
        //}
    }
}
