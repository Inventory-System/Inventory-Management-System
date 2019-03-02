using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public class Product:BaseClass
    {
        public Product() {
            MeasurementId = measuerment.Id;
        }
        public string Name { get; set; }
        Measurement measuerment;
        public Guid MeasurementId { get; set; }
    }
}
