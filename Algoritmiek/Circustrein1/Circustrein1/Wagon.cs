using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Circustrein1
{
    public class Wagon
    {
        public List<Animal> AnimalList { get; set; }
        public int MaxCapacity { get; set; }

        public int Capacity { get; set; }

        public Wagon()
        {
            AnimalList = new List<Animal>();
            MaxCapacity = 10;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("(");
            foreach (Animal animal in AnimalList)
            {
                s.Append(animal.ToString() + ",");
            }
            s.Replace(",", ")", s.Length - 1, 1);
            
            return s.ToString();
        }
        

        public bool AddAnimalToWagon(Animal animal)
        {
            if (CheckWagonCapacity(animal) && AddHerbivore(animal) && SafeToAddCarnivore(animal) &&
                CheckCarnivoreSize(animal))
            {
                AnimalList.Add(animal);
                Capacity += (int) animal.Size;
                return true;
            }

            return false;
        }

        public bool CheckWagonCapacity(Animal animal)
        {
            if ((int) animal.Size + Capacity <= MaxCapacity)
            {
                return true;
            }

            return false;
        }

        public bool AddHerbivore(Animal animal)
        {
            foreach (Animal obj in AnimalList)
            {
                if (animal.Type == AnimalType.Herbivore && obj.Type == AnimalType.Carnivore && animal.Size <= obj.Size)
                {
                    return false;
                }
            }

            return true;
        }

        public bool SafeToAddCarnivore(Animal animal)
        {
            foreach (Animal obj in AnimalList)
            {
                if (animal.Type == AnimalType.Carnivore && obj.Type == AnimalType.Carnivore)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckCarnivoreSize(Animal animal)
        {
            foreach (Animal obj in AnimalList)
            {
                if (animal.Type == AnimalType.Carnivore && obj.Type == AnimalType.Herbivore && animal.Size >= obj.Size)
                {
                    return false;
                }
            }

            return true;
        }
    }
}