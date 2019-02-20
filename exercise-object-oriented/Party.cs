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
   
    class Party:BaseClass
    {
        public Party() 
        {
            posiontion = Position.None;
        }

        public int registrationNumber { get; set; }
        public DateTime registrationDate { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int phoneNumber { get; set; }
        public Position posiontion { get; set; }
    }
}
