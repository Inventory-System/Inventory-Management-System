using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Service;
using Inventory.Domain;
using Galaxy.Base.Domain.DAL;
using Inventory.Domain.ServiceInterface;

namespace InventoryService
{
    public class InventoryProductDocumentService : Service<InventoryProductDocument> , IInventoryProductDocumentService
    {
        public InventoryProductDocumentService(IRepository<InventoryProductDocument> repository) : base(repository)
        {
 
        }
    }
}
