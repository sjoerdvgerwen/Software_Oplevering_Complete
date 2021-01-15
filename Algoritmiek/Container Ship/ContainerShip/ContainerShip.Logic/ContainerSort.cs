using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerShip.Logic
{
    public class ContainerSort
    {
        public List<Container> Containers { get; set; }

        public ContainerSort(List<Container> unsortedContainers)
        {
            var sortedContainers = unsortedContainers
                .OrderByDescending(container => container.type == Container.Type.Cooled)
                .ThenByDescending(container => container.type == Container.Type.Normal)
                .ThenByDescending(container => container.ContainerWeight);

            Containers = sortedContainers.ToList();
            Console.WriteLine(Containers.Count);
        }


        public void FillShip(Ship ship, List<Container> sortedContainers)
        {
            if (AllowedToLoadContainers(sortedContainers) && MinimumShipWeight(ship, sortedContainers)
            ) //Als containers aan de gewichtnormen voldoen en er geen kapzeis gevaar is
            {
                foreach (Container container in sortedContainers)
                    if (ship.FillRows(container) == false)
                    Console.WriteLine("Ship can't be loaded because there is not enough space. Container " + container.type + " with weight " + container.ContainerWeight + "can't be loaded");
                
            }

            foreach (Container container in sortedContainers)
            {
                if (AllowedToLoadContainers(sortedContainers) == false)
                    Console.WriteLine("Can't add container: " + container.type + " " + container.ContainerWeight);
                

                if (MinimumShipWeight(ship, sortedContainers) == false)
                {
                    Console.WriteLine("The ship needs more weight to be able to departure.");
                }
            }
        }


        public int TotalContainersWeight(List<Container> sortedContainers)
        {
            int totalWeight = 0;
            foreach (var container in sortedContainers)
            {
                totalWeight += container.ContainerWeight;
            }

            return totalWeight;
        }

        public bool MinimumShipWeight(Ship ship, List<Container> sortedContainers)
        {
            int totalContainerWeight = TotalContainersWeight(sortedContainers);
            var minimumShipWeight = ship.ShipWeight / 2;
            if (totalContainerWeight > minimumShipWeight)
            {
                return true;
            }

            return false;
        }

        public bool AllowedToLoadContainers(List<Container> sortedContainers)
        {
            if (sortedContainers.Count == 0) return false;

            foreach (var container in sortedContainers)
            {
                if (container.ContainerWeight > container.MaxContainerWeight || container.ContainerWeight < container.MinimumContainerWeight)
                {
                    return false;
                }
            }

            return true;
        }
    }
}