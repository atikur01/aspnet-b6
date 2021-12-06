using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Topic
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Session> Sessions { get; set; }

        public Topic()
        {
            Title = "C#";
            Description = "Language";
            Sessions = new List<Session>();
            Sessions.Add( new Session() );
        }
    }
}
