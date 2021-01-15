using System;
using System.Collections.Generic;

namespace ContainerShip.Logic
{
    public class ContainerInput
    {
        public static readonly Random Random = new Random();

        public List<Container> GetUnsortedContainers()
        {
            List<Container> unsortedContainers = new List<Container>();

            var type = Enum.GetValues(typeof(Container.Type));

            for (int i = 0; i < 60; i++)
            {
                Container container = new Container();
                container.type = (Container.Type) type.GetValue(Random.Next(type.Length));
                container.ContainerWeight = Random.Next(4000, 30000);

                unsortedContainers.Add(container);
            }

            return unsortedContainers;
        }
    }
}