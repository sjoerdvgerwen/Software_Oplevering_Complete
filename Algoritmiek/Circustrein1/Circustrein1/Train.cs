using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein1
{
    public class Train
    {
        public List<Wagon> Wagons;

        public Train()
        {
            Wagons = new List<Wagon>() {new Wagon()};
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (Wagon wagon in Wagons)
            {
                s.Append(wagon.ToString() + "\n" + "\n");
            }

            return s.ToString();
        }

        public void AddToWagon(List<Animal> animal)
        {
            foreach (Animal obj in animal)
            {
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.AddAnimalToWagon(obj))
                    {
                        break;
                    }

                    else if (Wagons.IndexOf(wagon) == Wagons.Count - 1) 
                    {
                        Wagon newWagon = new Wagon();
                        newWagon.AddAnimalToWagon(obj);
                        Wagons.Add(newWagon);
                        break;
                    }
                }
            }
        }
    }
}