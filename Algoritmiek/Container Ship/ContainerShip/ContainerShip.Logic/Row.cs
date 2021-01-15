using System;
using System.Collections.Generic;
using System.Linq;

namespace ContainerShip.Logic
{
    public class Row
    {
        public int RowLength { get; set; }
        public int ColumnLength { get; set; }

        public List<Stack> Stacks = new List<Stack>();

        public Row(int rowLength, int columnLength)
        {
            RowLength = rowLength;
            ColumnLength = columnLength;

            Stacks = CreateStacks();
        }


        public List<Stack> CreateStacks()
        {
            List<Stack> stacks = new List<Stack>();

            for (int i = 0; i < ColumnLength; i++)
            {
                Stack stack = new Stack();
                stacks.Add(stack);
            }

            return stacks;
        }

        public override string ToString()
        {
            Console.WriteLine("Row - " + RowLength + " - Met breedte van " + ColumnLength);
            foreach (var stack in Stacks)
            {
                Console.WriteLine(stack.ToString());
            }

            return "";
        }

        public bool TryAddContainer(Container container)
        {
            if (IsContainerCooled(container))
            {
                return true;
            }

            if (IsContainerNormal(container))
            {
                return true;
            }

            if (IsContainerValuable(container))
            {
                return true;
            }

            return false;
        }

        
        
        public bool GetCurrentStackPosition(Container container)
        {
            foreach (var stack in Stacks)
            {
                if (!stack.IsLastContainerValuable()) ;
                var position = Stacks.IndexOf(stack);
                        var middle = Stacks.Count / 2;

                if (position < middle)
                {
                    if (GetLeft(stack, container))
                        return true;
                }
                
                if (position >= middle)
                    if (GetRight(stack, container))
                        return true;
                
            }

            return false;
        }

        public bool IsContainerCooled(Container container)
        {
            if (RowLength == 0 && container.type == Container.Type.Cooled)
                if (container.Placed == false)
                    if (GetCurrentStackPosition(container))
                    {
                        return true;
                    }
            return false;
        }

        public bool IsContainerNormal(Container container)
        {
            if (RowLength != 0 && container.type == Container.Type.Normal)
                if (container.Placed == false)
                    if (GetCurrentStackPosition(container))
                    {
                        return true;
                    }

            return false;
        }

        public bool IsContainerValuable(Container container)
        {
            if (container.type == Container.Type.Valuable)
                if (container.Placed == false)
                    if (GetCurrentStackPosition(container))
                    {
                        return true;
                    }
            
            return false;
        }

        public bool GetLeft(Stack stack, Container container)
        {
            var totalAmountOfColumns = Stacks.Count; // 4
            var halfAmountOfColumnCount = totalAmountOfColumns / 2; // 4/2=2

            var weightLeft = GetWeightLeft(halfAmountOfColumnCount);
            var weightRight = GetWeightRight(halfAmountOfColumnCount, totalAmountOfColumns);
            List<Stack> LeftStacks = new List<Stack>(); 
            //create list of left stacks
            for (int i = 0; i < halfAmountOfColumnCount; i++)
            {
                LeftStacks.Add(Stacks[i]);
            }
            
            //methode om te checken welke van de LeftStacks het leegste is
            Stack lowestStack = LeftStacks[0];
            if (weightLeft <= weightRight)
            {
                //je leegste container
                if (lowestStack.AddToStack(container))
                {
                    return true;
                }
            }

            return false;
        }


        public bool GetRight(Stack stack, Container container)
        {
            var totalAmountOfColumns = Stacks.Count; // 4
            var halfwaysColumnCount = totalAmountOfColumns / 2; // 4/2=2

            var weightLeft = GetWeightLeft(halfwaysColumnCount);
            var weightRight = GetWeightRight(halfwaysColumnCount, totalAmountOfColumns);

            if (weightRight <= weightLeft)
            { 
                if (stack.AddToStack(container))
                {
                    return true;
                }
            }

            return false;
        }

        private int GetWeightLeft(int halfwaysColumnCount)
        {
            var weightLeft = 0;
            for (int i = 0; i < halfwaysColumnCount; i++)
            {
                weightLeft = weightLeft + Stacks[i].containers.Sum(c => c.ContainerWeight);
            }

            return weightLeft;
        }

        private int GetWeightRight(int halfwaysColumnCount, int totalColumnCount)
        {
            var weightRight = 0;
            {
                for (int i = halfwaysColumnCount; i < totalColumnCount; i++)
                {
                    weightRight = weightRight + Stacks[i].containers.Sum(c => c.ContainerWeight);
                }

                return weightRight;
            }
        }
    }
}
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        