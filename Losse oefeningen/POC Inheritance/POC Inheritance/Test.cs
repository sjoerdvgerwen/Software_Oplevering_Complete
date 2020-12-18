using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace POC_Inheritance
{
    public class Test
    {
        static void Main(string[] args)
        {
            

            Course testcourse = new Course("John", 21, "ICT", 2020);

            List<Course> studentcourse = new List<Course>();
            studentcourse.Add(testcourse);

            Console.WriteLine(testcourse.Name);
        }
    }
}
