using System.Collections.Generic;

namespace exercise_object_oriented
{
    public class CalculationFactor:BaseClass
    {
        public virtual decimal CalculatedPrice { get; set; }
        public virtual Factor Factor { get; set; }
       // public virtual ProductDocument ProductDocument { get; set; }
    }
}