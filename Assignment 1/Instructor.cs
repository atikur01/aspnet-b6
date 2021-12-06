using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Instructor
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Address PresentAddress { get; set; }
        public Address PermanentAddress { get; set; }
        public List<Phone> PhoneNumbers { get; set; }

        public Instructor()
        {
            Name = "Jalaluddin";
            Email = "jalaluddin@gmail.com";
            PresentAddress = new Address();
            PermanentAddress = new Address();
            PhoneNumbers = new List<Phone>();
            PhoneNumbers.Add(new Phone());
        }
    }
}
