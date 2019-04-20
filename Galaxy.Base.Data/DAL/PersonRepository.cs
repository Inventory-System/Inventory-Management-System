using System;
using System.Collections.Generic;
using System.Linq;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain;
using NHibernate;
namespace Galaxy.Base.Data.DAL
{
    public class PersonRepository : Repository<Person>,IPersonRepository
    {
        public PersonRepository(ISession session , ITransaction transaction) : base(session , transaction)
        {
        }
    }
}
