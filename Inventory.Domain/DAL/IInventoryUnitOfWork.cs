using Galaxy.Base.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.DAL
{
    public interface IInventoryUnitOfWork : IUnitOfWork
    {
         IInventorytDocumentRepository InventoryDocumentRepository { get; }
         IInventoryProductDocumentRepository InventoryProductDocumentRepository { get; }  

    }
}
