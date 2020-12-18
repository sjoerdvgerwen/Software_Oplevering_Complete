using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace ContainerSort
{
    public class Ship
    
    {
        public int xvalue { get; set; }
        public int yvalue { get; set; }
        public int loadcapacity { get; set; }
        public int Xvalue { get; set; }
        public int Yvalue { get; set; }
        public int LoadCapacity { get; set; }
        
        public Ship()
        {
            Xvalue = xvalue;
            Yvalue = yvalue;
            LoadCapacity = loadcapacity;
            List<Container>ListOfContainers = new List<Container>();
        }
        
        
        
        
        
        
        
        
        
    }
}