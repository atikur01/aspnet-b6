using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Course
    {
        public string Title { get; set; }
        public Instructor Teacher { get; set; }
        public List<Topic> Topics { get; set; }
        public double Fees { get; set; }
        public List<AdmissionTest> Tests { get; set; }

        public Course()
        {
            Title = "Asp.net";
            Teacher = new Instructor();
            Topics = new List<Topic>(); 
            Topics.Add(new Topic());
            Fees = 30000.00;
            Tests = new List<AdmissionTest>();
            Tests.Add(new AdmissionTest());

        }
    }
}
