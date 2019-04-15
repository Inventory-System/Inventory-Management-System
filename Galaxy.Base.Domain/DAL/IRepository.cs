using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Galaxy.Base.Domain.DAL
{
    public interface IRepository<T> where T : BaseClass
    {
        List<T> GetAll();
        T GetById(Guid id);
        object Find(Expression<Func<T, bool>> expression);

        void Add(T entity);
        void AddRange(List<T> entities);

        void Remove(T entity);
        void RemoveRange(List<T> entities);
    }
}
