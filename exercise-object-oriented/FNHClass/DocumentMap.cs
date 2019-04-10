using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;

namespace exercise_object_oriented.FNHFolder
{
    public class DocumentMap : IAutoMappingOverride<Document>
    {
        public void Override(AutoMapping<Document> mapping)
        {
            mapping.Map(x => x.CreateDate);
            mapping.References(x => x.Party);
        }
    }

    public class GenericDocumentMap : IAutoMappingOverride<Document<ProductDocument>>
    {
        public void Override(AutoMapping<Document<ProductDocument>> mapping)
        {
            mapping.HasMany(x => x.ProductDocumentsList);
        }
    }
}