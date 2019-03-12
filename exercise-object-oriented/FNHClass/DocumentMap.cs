using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHFolder
{
    class DocumentMap : IAutoMappingOverride<Document>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Document> mapping)
        {
            mapping.Map(x => x.CreateDate);
            mapping.Map(x => x.party);
            // HasMany(x => x.ProductDocumentsList);
          //  mapping.DiscriminateSubClassesOnColumn("");
          //  DiscriminateSubClassesOnColumn("FieldType");
        }
    }

    class Document2Map : IAutoMappingOverride<Document<ProductDocument>>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<Document<ProductDocument>> mapping)
        {
            mapping.HasMany(x => x.ProductDocumentsList);
        }
    }
}
