using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
{
    public abstract class Document : BaseClass
    {
        public Document()
        {
            CreateDate = DateTime.Now;
        }

        public DateTime CreateDate { get; set; }
        public int CodeDocument { get; set; }
    }


    public abstract class Document<T> : Document where T : ProductDocument
    {
        public List<T> DocumentsList { get; set; }
        public void Add(T TproductDoc)
        {
            DocumentsList.Add(TproductDoc);
        }


    }
}
