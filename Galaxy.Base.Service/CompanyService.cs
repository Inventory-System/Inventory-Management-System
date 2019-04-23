using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    class CompanyService:Service<Company>
    {
        public CompanyService(IRepository<Company> repository) : base(repository)
        {
        }
    }
}
