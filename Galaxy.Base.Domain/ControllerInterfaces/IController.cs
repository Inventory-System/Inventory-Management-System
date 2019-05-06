using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy.Base.Domain.ControllerInterfaces
{
    public interface IController<T> where T : BaseClass
    {
        void Create(T entity);
        T Read(Guid id);
        void Update(T entity);
        void Delete(Guid id);
    }
}
