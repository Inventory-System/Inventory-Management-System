using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain.DAL;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json.Linq;
using Sale.Domain.DAL;

namespace Sale.Data.DAL
{
    public class SaleUnitOfWorkRepository : UnitOfWork
    {
        public ISaleDocumentRepository SaleDocumentRepository { get; private set; }
        public ISaleProductDucumentRepository SaleProductDucumentRepository { get;private set ;}

        

    }
}
