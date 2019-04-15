using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain
{
    public interface IInventoryDocumentRepository
    {
        void Update(InventoryDocument document);
    }
}
