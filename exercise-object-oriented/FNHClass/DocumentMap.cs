using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHFolder
{
    public class DocumentMap : IAutoMappingOverride<Document>
    {
        public void Override(FluentNHibernate.Automapping.AutoMapping<Document> mapping)
        {
            mapping.Map(x => x.CreateDate);
            mapping.References(x => x.Party);

        }
    }

    public class GenericDocumentMap : IAutoMappingOverride<Document<ProductDocument>>
    {

        public void Override(FluentNHibernate.Automapping.AutoMapping<Document<ProductDocument>> mapping)
        {
            mapping.HasMany(x => x.ProductDocumentsList);
        }
    }
}
