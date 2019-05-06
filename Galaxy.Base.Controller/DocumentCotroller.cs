using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.ControllerInterfaces;
using Galaxy.Base.Domain.ServiceInterfaces;

namespace Galaxy.Base.Controller
{
    public class DocumentCotroller : Controller<Document> , IDocumentController
    {
        public DocumentCotroller(IService<Document> Service) : base(Service)
        {
        }
    }
}
