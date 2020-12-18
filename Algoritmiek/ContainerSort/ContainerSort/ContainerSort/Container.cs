using System.Collections.Generic;

namespace ContainerSort
{
    public class Container
    {
        public int Weight { get; set; }
        public bool Valuable { get; set; }
        public bool Coolable { get; set; }

        public Container(int weight, bool coolable, bool valuable)
        {
            Weight = weight;
            Coolable = coolable;
            Valuable = valuable;
        }
        
        
        
    }
}