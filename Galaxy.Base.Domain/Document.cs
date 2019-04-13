using System;
using System.Collections.Generic;

namespace Galaxy.Base.Domain
{
    public abstract class Document : BaseClass
    {
        public Document()
        {
            CreateDate = DateTime.Now;
        }
        public virtual DateTime CreateDate { get; set; }
        public virtual Party Party { get; set; }
    }


    public abstract class Document<T> : Document where T : ProductDocument
    {
        public virtual List<T> ProductDocumentsList { get; set; }
        public  virtual void Add(T TproductDoc)
        {
            ProductDocumentsList.Add(TproductDoc);
        }
 

    }
}
