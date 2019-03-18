using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class SubsidiaryUnit : BaseClass
    {
        public SubsidiaryUnit()
        {
        }
        public virtual string SubsidiaryUnitName { set; get; }
        public virtual int Coefficient { get; set; }
        public virtual Measurement measurement { get; set; }
    }
}
