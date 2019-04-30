
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;

namespace Purchase.Service
{
    class PurchaseDocumentService:Service<PurchaseDocument>
    {
        public PurchaseDocumentService(IRepository<PurchaseDocument> repository) : base(repository)
        {
        }
    }
}
