using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    class PersonService:Service<Person>
    {
        public PersonService(IRepository<Person> repository) : base(repository)
        {
        }
    }
}
