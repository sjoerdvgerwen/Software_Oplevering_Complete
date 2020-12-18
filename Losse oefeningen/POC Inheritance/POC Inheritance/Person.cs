using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace POC_Inheritance
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            
        }

       // public override string ToString()
       // {
       //     return "Person with name" + Name + "who is" + Age + "years old.";
       // }
    }
}
