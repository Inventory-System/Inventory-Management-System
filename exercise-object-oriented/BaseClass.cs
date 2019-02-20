using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
     public abstract class BaseClass
    {
         public Guid id
         {
             get { return new Guid(); }
         }
        public int code { get; set; }
    }
}
