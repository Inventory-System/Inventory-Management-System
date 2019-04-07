using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
  public enum Operation 
    {
        Percentage, Amount,Unit
    }
    public class Tax:BaseClass
    {
        public string Name { get; set; }
        public bool Increasing{ get; set; }
        public Operation operation { get; set; }
        public decimal Quantity { get; set; }
    }
}
