using System;
using System.Collections.Generic;

namespace Circustrein1
{
    public class Program : Wagon
    {
        
        static void Main(string[] args)
        {
            List<Animal> animal = new List<Animal>();

            animal.Add(new Animal("Aap", (AnimalSize)1 , (AnimalType)0));
            animal.Add(new Animal("Vogelbekdier", (AnimalSize)1, (AnimalType)1));
            animal.Add(new Animal("Tijger", (AnimalSize)5, (AnimalType)1));
            animal.Add(new Animal("Olifant", (AnimalSize)5, (AnimalType)0));
            animal.Add(new Animal("Hyena", (AnimalSize)3, (AnimalType)1));
            animal.Add(new Animal("Chimpansee", (AnimalSize)3, (AnimalType)0));
            animal.Add(new Animal("Giraffe", (AnimalSize)5, (AnimalType)0));
            animal.Add(new Animal("Zebra", (AnimalSize)3, (AnimalType)0));
            animal.Add(new Animal("Paard", (AnimalSize)3, (AnimalType)0));
            animal.Add(new Animal("Leeuw", (AnimalSize)3, (AnimalType)1));
            animal.Add(new Animal("Uil", (AnimalSize)1, (AnimalType)1));


            Train t = new Train();
            t.AddToWagon(animal);

            Console.WriteLine(t);
            
            
            
        }
    }
}
