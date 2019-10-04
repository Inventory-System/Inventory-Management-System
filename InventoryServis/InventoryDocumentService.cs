using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;
using Inventory.Domain.ServiceInterface;

namespace InventoryService
{
    public class InventoryDocumentService : Service<InventoryDocument> , IInventoryDocumentService
    {
        public InventoryDocumentService(IRepository<InventoryDocument> repository): base(repository)
        {
 
        }
    }
}
