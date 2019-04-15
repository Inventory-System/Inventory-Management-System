using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Domain;
using Galaxy.Base.Domain.DAL;
using NHibernate;

namespace Galaxy.Base.Data.DAL
{
    public class ProductRepository: Repository<Product>, IProductRepository
    {
        public ProductRepository(ISession session, ITransaction transaction) : base(session, transaction)
        {
            
        }

        public void Update(Product product2)
        {
            Product product = GetById(product2.Id);
            if (product == null)
            {
                Add(product2);
            }
            else
            {
                product.Id = product2.Id;
                product.Name = product2.Name;
               // product.measurement = product2.measurement;
              //  product.SubsidiaryMeasurement = product2.SubsidiaryMeasurement;
                product.Code = product2.Code;

            }
        }
    }
}
