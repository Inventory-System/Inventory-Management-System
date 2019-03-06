using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
   public class Company:Party
    {
        public virtual string CompanyName{ get; set; }
        public virtual string JobTitle { get; set; }
    }
}
