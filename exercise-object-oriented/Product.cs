using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class Product:BaseClass
    {
        public override Guid id
        {
            get { return new Guid(); }
        }
        public Product() {
            measurementId = measuerment.id;
        }
        public string name { get; set; }
        Measurement measuerment;
        public Guid measurementId { get; set; }
    }
}
