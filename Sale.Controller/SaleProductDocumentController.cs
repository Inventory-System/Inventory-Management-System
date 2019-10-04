using Galaxy.Base.Controller;
using Galaxy.Base.Domain.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sale.Domain.ControllerInterface;

namespace Sale.Controller
{
    public class SaleProductDocumentController:Controller<SaleProductDocument>, ISaleProductDocumentController
    {
        public SaleProductDocumentController(IService<SaleProductDocument> Service) : base(Service)
        {
        }
    }
}
