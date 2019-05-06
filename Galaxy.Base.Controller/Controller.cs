using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.ControllerInterfaces;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace Galaxy.Base.Controller
{
    public class Controller<T> : IController<T> where T : BaseClass
    {
        private readonly IService<T> Service;

        public Controller(IService<T> Service)
        {
            this.Service = Service;
        }
        public void Create(T entity)
        {
            Service.Create(entity);
        }

        public T Read(Guid id)
        {
            return Service.Read(id);
        }

        public void Update(T entity)
        {
            Service.Update(entity);
        }

        public void Delete(Guid id)
        {
            Service.Delete(id);
        }
    }
}
