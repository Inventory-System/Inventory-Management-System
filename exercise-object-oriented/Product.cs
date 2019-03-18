using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class Product : BaseClass
    {
        public Product()
        {
        }
        public virtual string Name { get; set; }
        public virtual SubsidiaryUnit subsidiaryUnit { get; set; }
        public virtual Measurement measurement { get; set; }

        public virtual List<SubsidiaryUnit> SubsidiaryUnitList { get; set; }
    }
}
