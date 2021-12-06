
using System;
using Assignment_1;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;

namespace Assignment_1
{
    class Proram
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            //PrintProperties(course);
            var json = JsonFormatter.Convert<Course>(course);

            Console.WriteLine("{"+json+"}");
            

        }
    }
}


