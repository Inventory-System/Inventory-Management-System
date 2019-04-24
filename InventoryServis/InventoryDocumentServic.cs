using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Service;

namespace InventoryServis
{
    public class InventoryDocumentServic : Service<InventoryDocument>
    {
        public InventoryDocumentServic(IRepository<InventoryDocument> repository): base(repository)
        {
 
        }
    }
}
