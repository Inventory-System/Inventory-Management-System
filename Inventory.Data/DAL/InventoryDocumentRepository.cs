using Galaxy.Base.Data.DAL;
using Inventory.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.DAL
{
   public  class InventoryDocumentRepository:Repository<InventoryDocument>:IInventoryDocumentRepository
    {
        public InventoryDocumentRepository(ISession session , ITransaction transaction) : base(session , transaction)
        {

        }
    }
}
