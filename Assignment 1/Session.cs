using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Session
    {
        public int DurationInHour { get; set; }
        public string LearningObjective { get; set; }

        public Session()
        {
            DurationInHour = 3;
            LearningObjective = "describe the knowledge(s), skills, values, and habits of mind";
        }
    }
}
