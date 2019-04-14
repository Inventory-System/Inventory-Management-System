using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Sale.Service.DAL
{
    public interface ISaleRepository<T>
    {
        T Get(object key);
        T Save(T entity);
        T Update(T entity);
        void Delete(T entity);
        IQueryable<T> Find();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
