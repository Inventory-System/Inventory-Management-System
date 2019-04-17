using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;

namespace Sale.Domain.DAL
{
    public interface ISaleUnitOfWorkRepository :IUnitOfWork,IDisposable
    {
        
        ISaleDocumentRepository SaleDocumentRepository { get; }
        ISaleProductDucumentRepository ProductDucumentRepository { get; }
    }
}
