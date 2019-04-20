using Inventory.Domain.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;


namespace Inventory.Data.DAL
{
    public class InventoryUnitOfWorkRepository : UnitOfWork, IDisposable
    {
        public IInventorytDocumentRepository InventoryDocumentRepository { get; private set; }
        public IInventoryProductDocumentRepository InventoryProductDocumentRepository { get; private set; }
    }
}

