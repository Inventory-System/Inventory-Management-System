using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;

namespace Galaxy.Base.Service
{
    class ProductService : Service<Product>
    {
        public ProductService(IRepository<Product> repository) : base(repository)
        {

        }
    }
}
