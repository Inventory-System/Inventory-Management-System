using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    class FactorService:Service<Factor>
    {
        public FactorService(IRepository<Factor> repository) : base(repository)
        {
        }
    }
}
