using System;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    public class Service<T> where T : BaseClass
    {
        private IRepository<T> repository;

        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public void Create(T entity)
        {
            repository.Create(entity);
        }
        public T Read(Guid id)
        {
            return repository.Read(id);
        }
        /// <summary>
        /////////////////////////////////////////////////////////////////////-----IT MUST BE CHECK AGAIN-------///////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
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
        public void Delete(Guid id)
        {
            repository.Delete(id);
        }
    }
}
