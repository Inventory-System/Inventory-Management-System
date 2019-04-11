﻿using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Galaxy
{
    public class CalculationFactor:BaseClass
    {
        public virtual decimal CalculatedPrice { get; set; }
        public virtual Factor Factor { get; set; }
        // public virtual ProductDocument ProductDocument { get; set; }

        public virtual decimal CalculateFactor(decimal Price)
        {
            switch (Factor.operation)
            {
                case Operation.Percentage:
                    CalculatedPrice = Factor.Quantity / 100 * Price;
                    break;
                case Operation.Unit:
                    CalculatedPrice = Factor.Quantity;
                    break;
                case Operation.Amount:
                    ///////////////////////////////////////////****************************************************************************/////////////////////////////////////////
                    break;
                default:
                    break;
            }
            return CalculatedPrice;
        }

    }
}