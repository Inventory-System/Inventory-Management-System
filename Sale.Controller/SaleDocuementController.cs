using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Controller;
using Galaxy.Base.Domain.ServiceInterfaces;
using Sale.Domain.ControllerInterface;

namespace Sale.Controller
{
    class SaleDocuementController: Controller<SaleDocument>,ISaleDocumentController
    {
        public SaleDocuementController(IService<SaleDocument> Service) : base(Service)
        {
        }
    }
}
