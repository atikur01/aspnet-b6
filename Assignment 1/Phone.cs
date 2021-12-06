using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Phone
    {
        public string Number { get; set; }
        public string Extension { get; set; }
        public string CountryCode { get; set; }

        public Phone()
        {
            Number = "01747898758";
            Extension = "58";
            CountryCode = "880";
        }
    }
}
