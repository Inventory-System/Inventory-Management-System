using System;

namespace Galaxy.Base.Domain.ServiceInterfaces
{
    public interface IService<T> where T : BaseClass
    {
        void Create(T entity);
        T Read(Guid id);
        void Update(T entity);
        void Delete(Guid id);

    }
}
