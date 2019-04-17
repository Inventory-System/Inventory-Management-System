using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using NHibernate;
using Sale.Domain.DAL;

namespace Sale.Data.DAL
{
   public class SaleProductDocumentRepository:IRepository<SaleProductDocument>,ISaleProductDucumentRepository
    {
        public SaleProductDocumentRepository(ISession session, ITransaction transaction):base(session,transaction)
       {
           
       }
    }
}
