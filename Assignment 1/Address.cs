using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address()
        {
            Street = "3503 Golden Ridge Road";
            City = "Schenectady";
            Country = "USA";
        }
    }
}
