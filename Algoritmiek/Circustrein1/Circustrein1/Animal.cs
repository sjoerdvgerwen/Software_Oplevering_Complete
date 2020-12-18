using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein1
{
    public class Animal
    {

        public string Name { get; set; }
        public AnimalSize Size { get; set; }

        public AnimalType Type { get; set; }

        public Animal(string name, AnimalSize size, AnimalType type)
        {
            Name = name;
            Size = size;
            Type = type;
        }

        public override string ToString()
        {
            return Name + " " + Size + " "  + Type;
        }

    }
}
