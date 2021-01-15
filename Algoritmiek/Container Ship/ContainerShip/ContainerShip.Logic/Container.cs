namespace ContainerShip.Logic
{
    public class Container
    {
        public int ContainerWeight { get; set; }

        public int MaxContainerWeight = 30000;

        public int MinimumContainerWeight = 4000;
        public bool Placed { get; set; }

        public Type type;
        
        public override string ToString()
        {
            return ("Container of " + this.ContainerWeight + " weight , which is " + this.type);
        }

        public Container(Type type = Type.Normal, int weight = 4000)
        {
            ContainerWeight = weight;
                this.type = type;
        }

        public enum Type
        {
            Cooled, 
            Valuable,
            Normal
        }
    }
}