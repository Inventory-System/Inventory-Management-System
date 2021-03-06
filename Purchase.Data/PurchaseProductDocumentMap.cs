﻿
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchase
{
    class PurchaseProductDocumentMap:IAutoMappingOverride<PurchaseProductDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<PurchaseProductDocument> mapping)
        {
            mapping.References(x => x.product);
            mapping.Map(x => x.Code);
           // mapping.Map(x => x.CalculatePrice);
            mapping.Map(x => x.CalculationFactorsList);
            mapping.Map(x => x.OrginalPrice);
            mapping.Map(x => x.Price);



        }
    }
}
