using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using Galaxy.Base.Domain.ServiceInterface;

namespace Galaxy.Base.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IRepository<Product> repository) : base(repository)
        {

        }
    }
}
