using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;
using Purchase.Domain.ServiceInterface;

namespace Purchase.Service
{
    public class PurchaseProductDocumentService:Service<PurchaseProductDocument>, IPurchaseProductDocumentService 
    {
        public PurchaseProductDocumentService(IRepository<PurchaseProductDocument> repository) : base(repository)
        {
        }
    }
}
