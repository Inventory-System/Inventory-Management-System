using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_object_oriented
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
            posiontion = Position.None;
        }

        public int RegistrationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Position posiontion { get; set; }
    }
}
