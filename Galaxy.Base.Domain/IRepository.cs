using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.Base.Domain
{
    interface IRepository<T> where T : BaseClass
    {
        List<T> GetAll();
        T GetById(int id);
        List<T> Find(T entity);

        void Add(T entity);
        void AddRange(List<T> entities);

        void Remove(T entity);
        void RemoveRange(List<T> entities);
    }
}
