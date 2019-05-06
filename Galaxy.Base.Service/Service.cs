using System;
using Galaxy.Base.Data;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace Galaxy.Base.Service
{
    public class Service<T> :IService<T> where T : BaseClass
    {
        private IRepository<T> repository;

        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }

        [UnitOfWork]
        public void Create(T entity)
        {
            repository.Create(entity);
        }


        [UnitOfWork]
        public T Read(Guid id)
        {
            return repository.Read(id);
        }
        /// <summary>
        /////////////////////////////////////////////////////////////////////-----IT MUST BE CHECK AGAIN-------///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        [UnitOfWork]
        public void Update(T entity)
        {
            T tmp;
            tmp=repository.Read(entity.Id);
            if (tmp == null)
            {
                tmp.Id = new Guid();
            }
            else
            {
                tmp.Id = entity.Id;
            }
           repository.Create(tmp);
        }

        [UnitOfWork]
        public void Delete(Guid id)
        {
            repository.Delete(id);
        }
    }
}
