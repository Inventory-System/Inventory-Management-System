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
    public class PurchaseDocumentRepository : Repository<PurchaseDocument> , IPurchaseDocumentRepository
    {
    }
}
