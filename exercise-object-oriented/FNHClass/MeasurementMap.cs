using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace exercise_object_oriented.Mapping
{
    class MeasurementMap:ClassMap<Measurement>
    {
        public MeasurementMap()
        {
            Map(x => x.Name);
        }
    }
}
