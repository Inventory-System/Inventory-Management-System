using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    [Flags]
    public enum Position
    {
        None = 0x0,
        Customer = 0x1,
        Supplier = 0x2,
        Employee = 0x4
    }
   
  public  class Party:BaseClass
    {
        public Party() 
        {
            Posiontion = Position.None;
        }

        public virtual int RegistrationNumber { get; set; }
        public virtual DateTime RegistrationDate { get; set; }
        public virtual string Address { get; set; }
        public virtual int PhoneNumber { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual Position Posiontion { get; set; }
    }
}
