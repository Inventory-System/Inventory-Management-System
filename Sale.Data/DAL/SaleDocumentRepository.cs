using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using NHibernate;

namespace Sale.Data.DAL
{
   public class SaleDocumentRepository:Repository<SaleDocument>
    {
       public SaleDocumentRepository(ISession session, ITransaction transaction):base(session,transaction)
       {
           
       }
    }
}
