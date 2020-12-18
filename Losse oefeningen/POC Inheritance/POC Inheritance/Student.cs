using System;
using System.Collections.Generic;
using System.Text;

namespace POC_Inheritance
{
    public class Student : Person
    {
        public string Course { get; set; }

        public Student(string name, int age, string course) : base(name, age)   // base referereert naar de constructor in Person, daarom hoeft name en age niet opnieuw geinstansieerd te worden.
                                                                                // course is niet geinstansieerd in de base constructor en komt er nu dus nieuw bij en moet daarom wél geinstansieerd worden.
                                                                                // Hiervoor zorgt inheritance dus, dat je niet opnieuw alles hoeft te instancieren.
        {

            Course = course;
        }
    }
}
