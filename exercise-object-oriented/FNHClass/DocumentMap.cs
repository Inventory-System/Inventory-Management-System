using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace exercise_object_oriented.FNHFolder
{
    class DocumentMap : ClassMap<Document>
    {
        public DocumentMap()
        {
            Map(x => x.CreateDate);
            DiscriminateSubClassesOnColumn("FieldType");
        }
    }

    class Document2Map : SubclassMap<Document<ProductDocument>>
    {
        public Document2Map()
        {
            DiscriminatorValue("dfs");
            HasMany(x => x.ProductDocumentsList);
        }
    }
}
