﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy;
using Galaxy.Base.Domain;

namespace Inventory.Domain
{
    public class InventoryDocument : Document<InventoryProductDocument>
    {
        public InventoryDocument()
        {

            //party.posiontion = Position.Supplier;
            DateIn = DateTime.Now;
        }
        
        public virtual DateTime EpxDate { set; get; }
        public virtual DateTime DateIn { set; get; }
        public virtual DateTime DateOut { set; get; }
    }
}
