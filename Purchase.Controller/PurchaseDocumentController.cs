using Galaxy.Base.Controller;
using Purchase.Domain.ControllerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace Purchase.Controller
{
    public class PurchaseDocumentController: Controller<PurchaseDocument>, IPurchaseDocumentController
    {
        public PurchaseDocumentController(IService<PurchaseDocument> Service) : base(Service)
        {
        }
    }
}
