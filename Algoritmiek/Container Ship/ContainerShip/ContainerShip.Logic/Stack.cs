using System;
using System.Collections.Generic;

namespace ContainerShip.Logic
{
    public class Stack
    {
        public int MaxStackableWeight;

        public int CurrentWeight;

        public List<Container> containers;

        public Stack()
        {
            int currentWeight = CurrentWeight;
            MaxStackableWeight = 120000;
            containers = new List<Container>();
        }

        public override string ToString()
        {
            Console.WriteLine("Stack weight- " + CurrentWeight + " - Met max gewicht van " + this.MaxStackableWeight);
            foreach (var container in containers)
            {
                Console.WriteLine(container.ToString());
            }

            return "";
        }
        
        public bool IsLastContainerValuable()
        {
            if (containers.Count == 0)
            {
                return false;
            }
            
            if (containers.Count > 0)
            {
                Container lastContainer = containers[containers.Count - 1];
                if (lastContainer.type == Container.Type.Valuable)
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddToStack(Container container)
        {
            if (AllowedToAddContainerOnStack(container) == false)
            {
                return false;
            }

            if (IsLastContainerValuable())
            {
                return false;
            }

            if (MaxStackableWeight > CurrentWeight)
            {
                {
                    containers.Add(container);
                    CalculateStackWeight(container);
                    container.Placed = true;
                    return true;
                }
            }

            return false;
        }

        public bool AllowedToAddContainerOnStack(Container container)
        {
            int possibleNewWeight = CurrentWeight + container.ContainerWeight;
            if (possibleNewWeight > MaxStackableWeight)
            {
                return false;
            }

            return true;
        }

        public int CalculateStackWeight(Container container)
        {
            int newWeight = CurrentWeight += container.ContainerWeight;
            return newWeight;
        }
        
        
    }
}