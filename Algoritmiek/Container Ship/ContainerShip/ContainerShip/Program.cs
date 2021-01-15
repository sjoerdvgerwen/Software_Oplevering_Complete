using System;
using System.Collections.Generic;
using ContainerShip.Logic;

namespace ContainerShip
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the length of the containers on the ship:");
            int shipLength = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Write the width of the containers on the ship:");
            int shipWidth = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("What is the weight of the ship?");
            int shipWeight = Int32.Parse(Console.ReadLine());
            
            Ship ship = new Ship(shipWeight, shipLength, shipWidth);
            
            ContainerInput containerInput = new ContainerInput();

            ContainerSort containerSort = new ContainerSort(containerInput.GetUnsortedContainers());

            var SortedContainers = containerSort.Containers;
            
            containerSort.FillShip(ship, SortedContainers);

            Console.WriteLine(ship.ToString());
        }
    }
}