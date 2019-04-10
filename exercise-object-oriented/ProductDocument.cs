using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using NHibernate.Hql.Ast.ANTLR.Tree;

namespace exercise_object_oriented
{
    public abstract class ProductDocument : BaseClass
    {
        public virtual int OrginalPrice { get; set; }
        public virtual int Piece { get; set; }
        public virtual int Profit { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Product product { get; set; }

        public virtual List<CalculationFactor> CalculationFactorsList { get; set; }



        public decimal CalculatePrice()
        {
            int tmpPriority = 0;
            decimal tmpPrice = 0;
            decimal CurrentPrice = Price;
            List<CalculationFactor> SortedList = CalculationFactorsList.OrderBy(o => o.Factor.Priority).ToList();
            
            for (var i = 1; i <= SortedList.Count(); i++)
            {
                if (tmpPriority != SortedList[i].Factor.Priority)
                {
                    tmpPriority = SortedList[i].Factor.Priority;
                    tmpPrice = CurrentPrice;
                }
                decimal QuantityFactor = SortedList[i].CalculateFactor(tmpPrice);
                if (SortedList[i].Factor.Increasing)
                    CurrentPrice += QuantityFactor;
                else
                    CurrentPrice -= QuantityFactor;
            }

            return CurrentPrice;
        }
    }



    public abstract class ProductDocument<T> : ProductDocument where T : Document
    {
        public virtual T Document { get; set; }
    }
}