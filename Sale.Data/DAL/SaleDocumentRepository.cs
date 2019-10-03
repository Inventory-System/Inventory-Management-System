using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using NHibernate;
using Sale.Domain.DAL;

namespace Sale.Data.DAL
{
   public class SaleDocumentRepository:Repository<SaleDocument>,ISaleDocumentRepository
    {
    }
}
