using Galaxy.Base.Data.DAL;
using Inventory.Domain;
using Inventory.Domain.DAL;
using NHibernate;

namespace Inventory.Data.DAL
{
    public class InventoryProductDocumentRepository:Repository<InventoryProductDocument> , IInventoryProductDocumentRepository
    {
       
    }
}