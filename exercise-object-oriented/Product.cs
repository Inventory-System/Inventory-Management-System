﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class Product : BaseClass
    {
        public Product() {
        }
        public virtual string Name { get; set; }
        public virtual Measurement measuerment { get; set; }
    }
}
