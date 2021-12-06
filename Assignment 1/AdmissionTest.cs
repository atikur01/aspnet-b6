using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class AdmissionTest
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double TestFees { get; set; }

        public AdmissionTest()
        {
            StartDateTime = DateTime.Now;
            EndDateTime = DateTime.Now;
            TestFees = 100.00;
        }
    }
}
