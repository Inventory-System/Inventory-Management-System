using Galaxy.Base.Data.DAL;
using Inventory.Domain;
using Inventory.Domain.DAL;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.DAL
{
   public  class InventoryDocumentRepository:Repository<InventoryDocument> , IInventorytDocumentRepository
    {
       
    }
}
