using Galaxy.Base.Data.DAL;
using Inventory.Domain;
using NHibernate;

namespace Inventory.Data.DAL
{
    public class InventoryProductDocumentRepository:Repository<InventoryProductDocument> : IInventoryProductDocumentRepository
    {
        InventoryProductDocumentRepository(ISession session , ITransaction):base(session , transaction)
        {

        }
    }
}