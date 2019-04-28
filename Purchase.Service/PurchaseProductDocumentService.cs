using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;

namespace Purchase.Service
{
    public class PurchaseProductDocumentService:Service<PurchaseProductDocument>
    {
        public PurchaseProductDocumentService(IRepository<PurchaseProductDocument> repository) : base(repository)
        {
        }
    }
}
