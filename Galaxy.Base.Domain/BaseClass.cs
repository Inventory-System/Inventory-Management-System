using System;

namespace Galaxy.Base.Domain
{
     public abstract class BaseClass
    {
         public virtual Guid Id { get; set; }
        public virtual int Code { get; set; }
    }
}
