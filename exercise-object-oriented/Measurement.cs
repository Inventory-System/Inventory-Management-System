using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    class Measurement:BaseClass
    {
        public override Guid id
        {
            get { return new Guid(); }
        }
        public string  Name { get; set; }
    }
}
