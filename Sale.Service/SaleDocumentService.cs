using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;
using Sale.Domain.ServiceInterface;

namespace Sale.Service
{
   public class SaleDocumentService:Service<SaleDocument>,ISaleDocumentService
    {
       public SaleDocumentService(IRepository<SaleDocument> repository) : base(repository)
        {

        }
    }
}
