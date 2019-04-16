using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using NHibernate;

namespace Galaxy.Base.Data.DAL
{
   public class PartyRepository:Repository<Party>
    {
       public PartyRepository(ISession session, ITransaction transaction) : base(session, transaction)
       {
           
       }

    }
}
