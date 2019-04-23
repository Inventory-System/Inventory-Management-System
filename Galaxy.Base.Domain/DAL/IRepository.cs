using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Galaxy.Base.Domain.DAL
{
    public interface IRepository<T> where T : BaseClass
    {
        void Create(T entity);
        List<T> ReadAll();
        T Read(Guid id); 
        void Delete(Guid id); 

        //   object Find(Expression<Func<T, bool>> expression);
        //  void AddRange(List<T> entities);
        //   void RemoveRange(List<T> entities);
    }
}
