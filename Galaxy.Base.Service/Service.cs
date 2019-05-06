using System;
using Galaxy.Base.Data;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace Galaxy.Base.Service
{
    public class Service<T> :IService<T> where T : BaseClass
    {
        private readonly IRepository<T> Repository;

        public Service(IRepository<T> repository)
        {
            this.Repository = repository;
        }

        [UnitOfWork]
        public void Create(T entity)
        {
            Repository.Create(entity);
        }


        [UnitOfWork]
        public T Read(Guid id)
        {
            return Repository.Read(id);
        }
        /// <summary>
        /////////////////////////////////////////////////////////////////////-----IT MUST BE CHECK AGAIN-------///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 
        [UnitOfWork]
        public void Update(T entity)
        {
            T tmp;
            tmp=Repository.Read(entity.Id);
            if (tmp == null)
            {
                tmp.Id = new Guid();
            }
            else
            {
                tmp.Id = entity.Id;
            }
           Repository.Create(tmp);
        }

        [UnitOfWork]
        public void Delete(Guid id)
        {
            Repository.Delete(id);
        }
    }
}
