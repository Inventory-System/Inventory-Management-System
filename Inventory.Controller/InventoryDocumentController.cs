using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Controller;
using Galaxy.Base.Domain.ServiceInterfaces;
using Inventory.Domain;
using Inventory.Domain.ControllerInterface;

namespace Inventory.Controller
{
    public class InventoryDocumentController: Controller<InventoryDocument>,IInventoryDocumentController
    {
        public InventoryDocumentController(IService<InventoryDocument> Service) : base(Service)
        {
        }
    }
}
