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
            createDate = DateTime.Now;
        }

        public DateTime createDate { get; set; }
        public int codeDocument { get; set; }
    }


    public abstract class Document<T> : Document where T : ProductDocument
    {
        public List<T> documentsList { get; set; }
        public void Add(T TproductDoc)
        {
            documentsList.Add(TproductDoc);
        }


    }
}
