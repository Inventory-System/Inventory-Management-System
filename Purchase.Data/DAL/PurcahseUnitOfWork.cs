using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Purchase.Domain.DAL;

namespace Purchase.Data.DAL
{
    public class PurcahseUnitOfWork : UnitOfWork, IPurchaseUnitOfWork 
    {
        public IPurchaseProductDocumentRepository PurchaseProductDocumentRepository { get; private set; }
        public IPurchaseDocumentRepository PurchaseDocumentRepository { get; private set; }
         public PurcahseUnitOfWork()
         {
             PurchaseProductDocumentRepository = new PurchaseProductDocumentRepository(Session, Transaction);
             PurchaseDocumentRepository = new PurchaseDocumentRepository(Session, Transaction);
         }

    }
}
