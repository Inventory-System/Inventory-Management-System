using exercise_object_oriented;
using FluentNHibernate.Automapping.Alterations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.MapingClass
{
    class InventoryClassMaping
    {
    }

    public class InventryClassMaping : IAutoMappingOverride<InventoryDocument>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<InventoryDocument> mapmapping)
        {

        }
    
    }
}
