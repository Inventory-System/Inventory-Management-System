using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Service;
using Inventory.Domain;
using Galaxy.Base.Domain.DAL;

namespace InventoryServis
{
    public class InventoryProductDocumentService : Service<InventoryProductDocument>
    {
        public InventoryProductDocumentService(IRepository<InventoryProductDocument> repository) : base(repository)
        {
 
        }
    }
}
