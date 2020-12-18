using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Inheritance
{
    public class Course : Student
    {
        public int Schoolyear { get; set; }

        public Course(string name, int age, string course, int schoolyear) : base(name, age, course)
        {
            Schoolyear = schoolyear;
        }

       // public string Println()
       // {
        //    return String.Format(Name + Age + Course + Schoolyear);
       // }

        public List<Course> Studentinfo = new List<Course>();

        public void addStudent(Course course)
        {
            //  Studentinfo.Add(new Course("John", 21, "ICT", 2020));
            Studentinfo.Add(course);
        }


    }
}
