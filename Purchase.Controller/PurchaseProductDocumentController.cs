using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Controller;
using Galaxy.Base.Domain.ServiceInterfaces;
using Purchase.Domain.ControllerInterface;

namespace Purchase.Controller
{
    class PurchaseProductDocumentController:Controller<PurchaseProductDocument> , IPurcahseProductDocumentController
    {
        public PurchaseProductDocumentController(IService<PurchaseProductDocument> Service) : base(Service)
        {
        }
    }
}
