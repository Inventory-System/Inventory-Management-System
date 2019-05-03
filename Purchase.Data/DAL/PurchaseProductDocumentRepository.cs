using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using NHibernate;
using Purchase.Domain.DAL;

namespace Purchase.Data.DAL
{
    class PurchaseProductDocumentRepository : Repository<PurchaseProductDocument>, IPurchaseProductDocumentRepository
    {
        public PurchaseProductDocumentRepository(ISession session, ITransaction transaction) 
        {
        }
    }
}
